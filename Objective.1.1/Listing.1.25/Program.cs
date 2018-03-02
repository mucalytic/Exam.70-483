using System;
using System.Linq;

namespace Listing_1_25
{
    public class Program
    {
        // making a parallel query sequential
        public static void Main(string[] args)
        {
            Enumerable
                .Range(0, 20)
                .AsParallel()
                .AsOrdered()
                .Where(i => i % 2 == 0)
                .Take(5)
                .ToList()
                .ForEach(Console.WriteLine);

            Enumerable
                .Range(0, 20)
                .AsParallel()
                .AsOrdered()
                .Where(i => i % 2 == 0)
                .AsSequential()
                .Take(5)
                .ToList()
                .ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
