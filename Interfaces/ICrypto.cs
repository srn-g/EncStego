namespace EncStego.Interfaces
{
    public interface ICrypto
    {
        string Encrypt(string data_plain, string key);

        string Decrypt(string data_enc, string key);
    }
}