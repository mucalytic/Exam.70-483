using System;
using System.Threading;

namespace Listing_1_6
{
    public class Program
    {
        // using the ThreadLocal attribute
        private static readonly ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
                Thread.CurrentThread.ManagedThreadId);

        public static void Main(string[] args)
        {
            var tA = new Thread(() =>
            {
                for (var x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine($"Thread A: {x}");
                }
            });

            var tB = new Thread(() =>
            {
                for (var x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine($"Thread B: {x}");
                }
            });

            tA.Start();
            tB.Start();

            Console.ReadKey();
        }
    }
}
