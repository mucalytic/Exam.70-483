using System;
using System.Collections.Concurrent;

namespace Listing_1_30
{
    public class Program
    {
        // using a ConcurrentBag
        public static void Main(string[] args)
        {
            var bag = new ConcurrentBag<int> {42, 21};
            if (bag.TryTake(out var result1))
            {
                Console.WriteLine($"Took: {result1}");
            }

            if (bag.TryPeek(out var result2))
            {
                Console.WriteLine($"Peeked: {result2}");
            }

            Console.ReadKey();
        }
    }
}
