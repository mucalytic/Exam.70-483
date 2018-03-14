using System;
using System.IO;
using System.Security.Cryptography;

namespace Listing_3_17
{
    public class Program
    {
        // use a symmetric encryption algorithm
        public static void Main(string[] args)
        {
            const string original = "My Secret Data!";

            using (var symmetricAlgorithm = new AesManaged())
            {
                var encrypted = Encrypt(symmetricAlgorithm, original);
                var roundtrip = Decrypt(symmetricAlgorithm, encrypted);

                Console.WriteLine($"Original:  {original}");
                Console.WriteLine($"Roundtrip: {roundtrip}");
            }

            Console.ReadKey();
        }

        private static byte[] Encrypt(SymmetricAlgorithm algorithm, string text)
        {
            var encryptor = algorithm.CreateEncryptor(algorithm.Key, algorithm.IV);

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                using (var writer = new StreamWriter(cryptoStream))
                {
                    writer.Write(text);
                }

                return memoryStream.ToArray();
            }
        }

        private static string Decrypt(SymmetricAlgorithm algorithm, byte[] bytes)
        {
            var decryptor = algorithm.CreateDecryptor(algorithm.Key, algorithm.IV);

            using (var memoryStream = new MemoryStream(bytes))
            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
            using (var reader = new StreamReader(cryptoStream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
