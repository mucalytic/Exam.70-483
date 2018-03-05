using System;

namespace Listing_1_75
{
    public class Program
    {
        private delegate int Calculate(int x, int y);

        // using a delegate
        public static void Main(string[] args)
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); // 7

            calc = Multiply;

            Console.WriteLine(calc(3, 4)); // 12
            Console.ReadKey();
        }

        private static int Add(int x, int y) => x + y;

        private static int Multiply(int x, int y) => x * y;
    }
}
