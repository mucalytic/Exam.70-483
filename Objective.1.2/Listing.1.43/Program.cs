using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_43
{
    public class Program
    {
        // throwing OperationCanceledException
        public static void Main(string[] args)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;
            var task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }

                token.ThrowIfCancellationRequested();
            }, token);

            try
            {
                Console.WriteLine("Hit a key to stop the task");
                Console.ReadKey();

                source.Cancel();
                task.Wait();
            }
            catch (AggregateException exception)
            {
                Console.WriteLine($"Exception: {exception.InnerExceptions[0].Message}");
            }

            Console.WriteLine("Press enter to end the application");
            Console.ReadKey();
        }
    }
}
