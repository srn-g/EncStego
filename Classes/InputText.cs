using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncStego.Interfaces;
using EncStego.Classes;

namespace EncStego.Classes
{
    public class InputText : IInputData
    {
        public DataInfo GetDataInfo(string input)
        {
            var dataInfo = new DataInfo();
            dataInfo.Size = input.Length;
            dataInfo.Type = (int)Global.DataType.Text;
            dataInfo.Data = input;

            return dataInfo;
        }

        public string GetData(DataInfo input, string part)
        {
            string[] parts = part.Split('-');

            int start = Convert.ToInt32(parts[0]);
            int end = Convert.ToInt32(parts[1]);

            int length = end - start;

            return input.Data.Substring(start, length);
        }
    }
}
