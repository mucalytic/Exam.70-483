using System;
using System.Linq;

namespace Listing_1_23
{
    public class Program
    {
        // unordered parallel query
        public static void Main(string[] args)
        {
            Enumerable
                .Range(0, 10)
                .AsParallel()
                .Where(i => i % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
