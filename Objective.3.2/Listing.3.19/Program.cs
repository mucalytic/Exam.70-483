using System;
using System.Security.Cryptography;
using System.Text;

namespace Listing_3_19
{
    public class Program
    {
        // using a public and private key to encrypt and decrypt data
        public static void Main(string[] args)
        {
            RSAParameters publicKey;
            RSAParameters privateKey;

            using (var rsa = RSA.Create())
            {
                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);
            }

            var converter = new UnicodeEncoding();
            var bytes = converter.GetBytes("My Secret Data!");

            byte[] encrypted;

            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);
                encrypted = rsa.Encrypt(bytes, RSAEncryptionPadding.OaepSHA256);
            }

            byte[] decrypted;

            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);
                decrypted = rsa.Decrypt(encrypted, RSAEncryptionPadding.OaepSHA256);
            }

            var text = converter.GetString(decrypted);

            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
