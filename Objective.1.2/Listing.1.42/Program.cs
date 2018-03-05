using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_42
{
    public class Program
    {
        // using a CancellationToken
        public static void Main(string[] args)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;

            Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }, token);

            Console.WriteLine("Hit a key to stop task");
            Console.ReadKey();

            source.Cancel();

            Console.WriteLine("Hit a key to end application");
            Console.ReadKey();
        }
    }
}
