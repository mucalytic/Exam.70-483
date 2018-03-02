using System;
using System.Threading.Tasks;

namespace Listing_1_17
{
    public class Program
    {
        // using Parallel.Break
        public static void Main(string[] args)
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
                });

            Console.WriteLine($"IsCompleted: {r2.IsCompleted}, LowestBreakIteration: {r2.LowestBreakIteration}");
            Console.ReadKey();
        }
    }
}
