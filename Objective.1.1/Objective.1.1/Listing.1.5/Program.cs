using System;
using System.Threading;

namespace Listing_1_5
{
    public class Program
    {
        // using the ThreadStatic attribute
        [ThreadStatic]
        public static int _field;
        public static void Start(string[] args)
        {
            var tA = new Thread(() =>
            {
                for (var i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread A: {_field}");
                }
            });

            var tB = new Thread(() =>
            {
                for (var i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Thread B: {_field}");
                }
            });

            tA.Start();
            tB.Start();

            Console.ReadKey();
        }
    }
}
