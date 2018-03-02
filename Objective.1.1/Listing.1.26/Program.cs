using System;
using System.Linq;

namespace Listing_1_26
{
    public class Program
    {
        // using ForAll
        public static void Main(string[] args)
        {
            Enumerable
                .Range(0, 20)
                .AsParallel()
                .Where(i => i % 2 == 0)
                .ForAll(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
