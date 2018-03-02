using System;
using System.Threading;

namespace Listing_1_38
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gate = new object();
            var taken = false;

            try
            {
                Console.WriteLine($"1:{taken}");
                Monitor.Enter(gate, ref taken);
                Console.WriteLine($"2:{taken}");
            }
            finally
            {
                Console.WriteLine($"3:{taken}");

                if (taken)
                {
                    Console.WriteLine("4");
                    Monitor.Exit(gate);
                    Console.WriteLine("5");
                }

                Console.WriteLine($"6:{taken}");
            }

            Console.WriteLine("Hit a key");
            Console.ReadKey();
        }
    }
}
