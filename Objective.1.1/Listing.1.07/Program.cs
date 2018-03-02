using System;
using System.Threading;

namespace Listing_1_7
{
    public class Program
    {
        // queuing some work to the thread pool
        public static void Main(string[] args)
        {
            Console.WriteLine($"UI: {Thread.CurrentThread.ManagedThreadId}");

            ThreadPool.QueueUserWorkItem(s =>
            {
                Console.WriteLine($"Thread Pool: {Thread.CurrentThread.ManagedThreadId}");
            });

            Console.WriteLine($"UI: {Thread.CurrentThread.ManagedThreadId}");
            Console.ReadKey();
        }
    }
}
