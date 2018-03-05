using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_44
{
    public class Program
    {
        // adding a continuation for cancelled tasks
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

                throw new OperationCanceledException();
            }, token)
            .ContinueWith(t =>
            {
                Console.WriteLine("You have cancelled the task");
                t.Exception.Handle(e => true);
            }, TaskContinuationOptions.OnlyOnCanceled);

            try
            {
                Console.WriteLine("Hit a key to stop the task");
                Console.ReadKey();

                source.Cancel();
            }
            finally
            {
                Console.WriteLine("Press enter to end the application");
                Console.ReadKey();
            }
        }
    }
}
