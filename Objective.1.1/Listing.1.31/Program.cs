using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_31
{
    public class Program
    {
        // enumerating a ConcurrentBag
        public static void Main(string[] args)
        {
            var bag = new ConcurrentBag<int>();

            Task.Run(() =>
            {
                Console.WriteLine("Producer enter");
                bag.Add(42);
                Thread.Sleep(TimeSpan.FromSeconds(1));
                bag.Add(21);
                Console.WriteLine("Producer exit");
            });

            Task.Run(() =>
            {
                Console.WriteLine("Consumer enter");
                // only shows 42 because it's iterating
                // over a snapshot of the data in 'bag'
                // made when the foreach loop begins
                foreach (var i in bag)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Consumer exit");
            }).Wait();

            Console.WriteLine("Hit a key");
            Console.ReadKey();
        }
    }
}
