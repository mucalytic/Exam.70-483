using System;
using System.Collections.Concurrent;

namespace Listing_1_33
{
    public class Program
    {
        // using ConcurrentQueue
        public static void Main(string[] args)
        {
            var queue = new ConcurrentQueue<int>();

            queue.Enqueue(42);
            queue.Enqueue(7);

            if (queue.TryDequeue(out var result))
            {
                Console.WriteLine($"Dequeued: {result}");
            }

            Console.ReadKey();
        }
    }
}
