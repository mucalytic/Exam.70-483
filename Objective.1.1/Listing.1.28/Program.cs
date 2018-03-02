using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_28
{
    public class Program
    {
        // using BlockingCollection<T>
        public static void Main(string[] args)
        {
            var src = new CancellationTokenSource();
            var col = new BlockingCollection<string>();

            Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine(col.Take());
                }
            },
            src.Token);

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

                src.Cancel();
            })
            .Wait();
        }
    }
}
