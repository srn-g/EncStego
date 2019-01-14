using Bogus;
using EncStego.Interfaces;
using System;
using System.IO;
using System.Text;

namespace EncStego.Classes
{
    public class Main
    {
        private ICrypto _crypto;

        public ICrypto Crypto { set { _crypto = value; } }

        private IHash _hash;

        public IHash Hash { set { _hash = value; } }

        private ISplit _split;

        public ISplit Split { set { _split = value; } }

        private IInputData _data;

        public IInputData Data { set { _data = value; } }


        private static Main _instance;

        private Main()
        {

        }

        public static Main Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Main();
                }

                return _instance;
            }
        }


        public void Hide(string text, string password)
        {
            string folderPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + "\\Data\\";

            if (Directory.Exists(folderPath))
                Directory.Delete(folderPath, true);

            Directory.CreateDirectory(folderPath);

            var faker = new Faker("en");

            string data_enc = _crypto.Encrypt(text, _hash.GenerateHash(password));

            DataInfo dataInfo = _data.GetDataInfo(data_enc);

            string[] splittedData = _split.SplitData(dataInfo);

            for (int i = 0; i < splittedData.Length; i++)
            {
                string[] dataIndexes = splittedData[i].Split('-');

                int start = Convert.ToInt32(dataIndexes[0]);

                int end = Convert.ToInt32(dataIndexes[1]);

                int numberOfWords = end - start;

                string[] words = faker.Lorem.Words(numberOfWords);

                string dataPart = _data.GetData(dataInfo, splittedData[i]);

                for (int j = 0; j < words.Length; j++)
                {
                    int wordLength = words[j].Length;

                    int index = wordLength % 4;

                    if (index == wordLength)
                        index--;

                    var sbWord = new StringBuilder(words[j]);

                    sbWord[index] = dataPart[j];

                    words[j] = sbWord.ToString();
                }

                File.WriteAllText(folderPath + i + ".txt", string.Join(" ", words));
            }
        }

        public string Unhide(string folderPath, string password)
        {
            var text = new StringBuilder();

            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                string fileContent = File.ReadAllText(file);

                string[] words = fileContent.Split(' ');

                var part = new StringBuilder();
                for (int i = 0; i < words.Length; i++)
                {
                    int wordLength = words[i].Length;

                    int index = wordLength % 4;

                    if (index == wordLength)
                        index--;

                    
                    part.Append(words[i][index]);
                }

                text.Append(part);
            }

            return _crypto.Decrypt(text.ToString(), _hash.GenerateHash(password));
        }
    }
}
