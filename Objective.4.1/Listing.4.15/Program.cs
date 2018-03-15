using System;
using System.IO;

namespace Listing_4_15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var writer = File.CreateText(Path.Combine(Environment.CurrentDirectory, "test.dat")))
            {
                writer.Write("Test value!");
            }
        }
    }
}
