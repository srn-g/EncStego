using System;
using System.Text;
using EncStego.Interfaces;
using System.Security.Cryptography;

namespace EncStego.Classes
{
    public class SHA512Hash : IHash
    {
        public string GenerateHash(string input)
        {
            SHA512 sha = SHA512.Create();
            byte[] hash = sha.ComputeHash(Encoding.Default.GetBytes(input));

            return BitConverter.ToString(hash).Replace("-", string.Empty).ToUpper();
        }
    }
}
