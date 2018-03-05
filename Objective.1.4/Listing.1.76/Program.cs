using System;

namespace Listing_1_76
{
    public class Program
    {
        private static void MethodOne()
        {
            Console.WriteLine(nameof(MethodOne));
        }

        private static void MethodTwo()
        {
            Console.WriteLine(nameof(MethodTwo));
        }

        private delegate void Del();

        // a multicast delegate
        public static void Main(string[] args)
        {
            Del del = MethodOne;

            del += MethodTwo;

            del();

            Console.WriteLine(del.GetInvocationList().GetLength(0));
            Console.ReadKey();
        }
    }
}
