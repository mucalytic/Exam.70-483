using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Listing_3_23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sha256 = SHA256.Create();
            var converter = new UnicodeEncoding();
            var hashA = sha256.ComputeHash(converter.GetBytes("A paragraph of text"));
            var hashB = sha256.ComputeHash(converter.GetBytes("A paragraph of changed text"));
            var hashC = sha256.ComputeHash(converter.GetBytes("A paragraph of text"));

            Console.WriteLine(hashA.SequenceEqual(hashB));
            Console.WriteLine(hashA.SequenceEqual(hashC));
            Console.ReadKey();
        }
    }
}
