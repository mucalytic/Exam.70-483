using System;
using System.Diagnostics;

namespace Listing_3_42
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log("Blah");
            Console.ReadKey();
        }

        [Conditional("DEBUG")]
        private static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
