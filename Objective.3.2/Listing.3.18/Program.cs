using System;
using System.Security.Cryptography;

namespace Listing_3_18
{
    public class Program
    {
        // exporting a public key
        public static void Main(string[] args)
        {
            using (var rsa = RSA.Create())
            {
                var publicKey = rsa.ExportParameters(false);
                var privateKey = rsa.ExportParameters(true);

                Console.WriteLine(publicKey);
                Console.WriteLine(privateKey);
            }

            Console.ReadKey();
        }
    }
}
