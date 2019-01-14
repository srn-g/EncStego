using EncStego.Interfaces;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EncStego.Classes
{
    public class AES : ICrypto
    {
        public string Encrypt(string data_plain, string key)
        {
            if (string.IsNullOrEmpty(data_plain))
                return string.Empty;

            byte[] keyBytes = Encoding.Default.GetBytes(key);

            return Encrypt(data_plain, keyBytes);
        }

        public string Decrypt(string data_enc, string key)
        {
            if (string.IsNullOrEmpty(data_enc))
                return string.Empty;

            byte[] keyBytes = Encoding.Default.GetBytes(key);

            return Decrypt(data_enc, keyBytes);
        }

        private static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes;

            byte[] saltBytes = passwordBytes;

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (CryptoStream cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes;
            byte[] saltBytes = passwordBytes;

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (CryptoStream cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        private static string Encrypt(string text, byte[] passwordBytes)
        {
            byte[] originalBytes = Encoding.Default.GetBytes(text);
            byte[] encryptedBytes;

            // Getting the salt size
            int saltSize = GetSaltSize(passwordBytes);
            // Generating salt bytes
            byte[] saltBytes = GetRandomBytes(saltSize);

            // Appending salt bytes to original bytes
            byte[] bytesToBeEncrypted = new byte[saltBytes.Length + originalBytes.Length];
            for (int i = 0; i < saltBytes.Length; i++)
            {
                bytesToBeEncrypted[i] = saltBytes[i];
            }
            for (int i = 0; i < originalBytes.Length; i++)
            {
                bytesToBeEncrypted[i + saltBytes.Length] = originalBytes[i];
            }

            encryptedBytes = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            return Convert.ToBase64String(encryptedBytes);
        }

        private static string Decrypt(string decryptedText, byte[] passwordBytes)
        {
            byte[] bytesToBeDecrypted = Convert.FromBase64String(decryptedText);

            byte[] decryptedBytes = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            // Getting the size of salt
            int saltSize = GetSaltSize(passwordBytes);

            // Removing salt bytes, retrieving original bytes
            byte[] originalBytes = new byte[decryptedBytes.Length - saltSize];
            for (int i = saltSize; i < decryptedBytes.Length; i++)
            {
                originalBytes[i - saltSize] = decryptedBytes[i];
            }

            return Encoding.Default.GetString(originalBytes);
        }

        private static int GetSaltSize(byte[] passwordBytes)
        {
            var key = new Rfc2898DeriveBytes(passwordBytes, passwordBytes, 1000);
            byte[] ba = key.GetBytes(2);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ba.Length; i++)
            {
                sb.Append(Convert.ToInt32(ba[i]).ToString());
            }
            int saltSize = 0;
            string s = sb.ToString();
            foreach (char c in s)
            {
                int intc = Convert.ToInt32(c.ToString());
                saltSize += intc;
            }

            return saltSize;
        }

        private static byte[] GetRandomBytes(int length)
        {
            byte[] ba = new byte[length];
            RandomNumberGenerator.Create().GetBytes(ba);
            return ba;
        }
    }
}