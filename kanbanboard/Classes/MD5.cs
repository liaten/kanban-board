using System;
using System.Security.Cryptography;
using System.Text;

namespace kanbanboard.Classes
{
    internal static class MD5
    {
        // Расшифровка
        static public string Decrypt(string line)
        {
            var data = Convert.FromBase64String(line);
            using (var tripleDes = new TripleDESCryptoServiceProvider { Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes("R0CK5T4R")), Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                return Encoding.UTF8.GetString(tripleDes.CreateDecryptor().TransformFinalBlock(data, 0, data.Length));
        }

        // Зашифровка
        static public string Encrypt(string line)
        {
            var data = Encoding.UTF8.GetBytes(line);
            using (var tripleDes = new TripleDESCryptoServiceProvider { Key = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes("R0CK5T4R")), Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                return Convert.ToBase64String(tripleDes.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
        }
    }
}
