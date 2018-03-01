using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_16
{
    public class Program
    {
        // using Parallel.For and Parallel.ForEach
        public static void Start(string[] args)
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine($"For: {i}");
                Thread.Sleep(1000);
            });

            Parallel.ForEach(
                Enumerable.Range(0, 10), i =>
                {
                    Console.WriteLine($"ForEach: {i}");
                    Thread.Sleep(1000);
                });

            Console.ReadKey();
        }
    }
}
