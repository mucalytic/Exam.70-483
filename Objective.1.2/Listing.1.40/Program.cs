using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_40
{
    public class Program
    {
        // using the Interlocked class
        public static void Main(string[] args)
        {
            var n = 0;
            var up = Task.Run(() =>
            {
                for (var i = 0; i < 10_000_000; i++)
                {
                    Interlocked.Increment(ref n);
                }
            });

            for (var i = 0; i < 10_000_000; i++)
            {
                Interlocked.Decrement(ref n);
            }

            up.Wait();

            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
