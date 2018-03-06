using System;

namespace Listing_1_92
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s = Console.ReadLine();

            try
            {
                var i = int.Parse(s);
                if (i == 42)
                {
                    Environment.FailFast("Special number entered");
                }
            }
            finally
            {
                Console.WriteLine("Program complete");
            }

            Console.ReadKey();
        }
    }
}
