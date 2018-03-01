using System;
using System.Threading.Tasks;

namespace Listing_1_11
{
    public class Program
    {
        // scheduling different continuation tasks
        public static void Start(string[] args)
        {
            var t = Task.Run(() =>
            {
                return 42;
            });

            t.ContinueWith(i =>
            {
                Console.WriteLine("Cancelled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith(i =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            t.ContinueWith(i =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            t.Wait();

            Console.ReadKey();
        }
    }
}
