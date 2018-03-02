using System;
using System.Linq;

namespace Listing_1_27
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            try
            {
                numbers
                    .AsParallel()
                    .Where(IsEven)
                    .ForAll(Console.WriteLine);
            }
            catch (AggregateException exception)
            {
                Console.WriteLine($"There were {exception.InnerExceptions.Count} exceptions");
            }

            Console.ReadKey();
        }

        private static bool IsEven(int i)
        {
            if (i % 10 == 0)
            {
                throw new ArgumentException(nameof(i));
            }

            return (i % 2 == 0);
        }
    }
}
