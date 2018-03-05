using System;

namespace Listing_1_79
{
    public class Program
    {
        private delegate int Calculate(int x, int y);

        // lambda expression to create a delegate
        public static void Main(string[] args)
        {
            Calculate calc = (x, y) => x + y;

            Console.WriteLine(calc(3, 4)); // 7

            calc = (x, y) => x * y;

            Console.WriteLine(calc(3, 4)); // 12
            Console.ReadKey();
        }
    }
}
