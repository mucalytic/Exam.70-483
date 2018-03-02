using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Listing_1_29
{
    public class Program
    {
        // using GetConsumingEnumerable on a BlockingCollection<T>
        public static void Main(string[] args)
        {
            var col = new BlockingCollection<string>();

            Task.Run(() =>
            {
                foreach (var text in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(text);
                }

                Console.WriteLine("Read loop finished");
                Console.WriteLine("Hit a key to exit");
            });

            Task.Run(() =>
            {
                while (true)
                {
                    var text = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(text))
                    {
                        break;
                    }

                    col.Add(text);
                }

                Console.WriteLine("Write loop finished");

                col.CompleteAdding();
            }).Wait();

            Console.ReadKey();
        }
    }
}
