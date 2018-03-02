using System;
using System.Collections.Concurrent;

namespace Listing_1_34
{
    public class Program
    {
        // using ConcurrentDictionary
        public static void Main(string[] args)
        {
            var dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine($"Added k1:{dict["k1"]}");
            }

            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine($"k1:42 updated to {dict["k1"]}");
            }

            dict["k1"] = 42; // overwrite unconditionally

            Console.WriteLine($"k1:21 overwritten with {dict["k1"]}");
            Console.Write("AddedOrUpdate (add=3|update=k1*2) k1:");
            Console.WriteLine(dict.AddOrUpdate("k1", 3, (key, value) => value * 2));
            Console.Write("GetOrAdd k2:");
            Console.WriteLine(dict.GetOrAdd("k2", 3));
            Console.ReadKey();
        }
    }
}
