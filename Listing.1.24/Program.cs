using System;
using System.Linq;

namespace Listing_1_24
{
    public class Program
    {
        // ordered parallel query
        public static void Main(string[] args)
        {
            Enumerable
                .Range(0, 10)
                .AsParallel()
                .AsOrdered()
                .Where(i => i % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
