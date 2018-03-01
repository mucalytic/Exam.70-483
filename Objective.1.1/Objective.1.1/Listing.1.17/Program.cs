using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_17
{
    public class Program
    {
        // using Parallel.Break
        public static void Start(string[] args)
        {
            var r1 =
                Parallel.For(0, 1000, (i, ls) =>
                {
                    Console.Write($"{i},");

                    if (i == 500)
                    {
                        Console.WriteLine("Breaking loop");
                        
                        ls.Break();
                    }

                    return;
                });

            Console.WriteLine($"IsCompleted: {r1.IsCompleted}, LowestBreakIteration: {r1.LowestBreakIteration}");
            Console.ReadKey();

            var r2 =
                Parallel.For(0, 1000, (i, ls) =>
                {
                    Console.Write($"{i},");

                    if (i == 500)
                    {
                        Console.WriteLine("Stopping loop");
                        
                        ls.Stop();
                    }

                    return;
                });

            Console.WriteLine($"IsCompleted: {r1.IsCompleted}, LowestBreakIteration: {r1.LowestBreakIteration}");
            Console.ReadKey();
        }
    }
}
