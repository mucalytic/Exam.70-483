using System;
using System.Collections.Concurrent;

namespace Listing_1_32
{
    public class Program
    {
        // using a ConcurrentStack
        public static void Main(string[] args)
        {
            var stack = new ConcurrentStack<int>();

            stack.Push(42);

            if (stack.TryPop(out var result))
            {
                Console.WriteLine($"Popped: {result}");
            }

            stack.PushRange(new[] { 1, 2, 3 });

            var values = new int[2];

            stack.TryPopRange(values);

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
