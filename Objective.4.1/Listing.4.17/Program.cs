using System;
using System.IO;

namespace Listing_4_17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "test.dat");

            using (var writer = File.CreateText(path))
            {
                writer.Write("Test value!");
            }

            using (var reader = File.OpenText(path))
            {
                Console.WriteLine(reader.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
