using System;
using System.Threading;

namespace Listing_1_2
{
    public class Program
    {
        private static void ThreadMethod()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(1000);
            }
        }

        // using a background thread
        public static void Main(string[] args)
        {
            var t = new Thread(ThreadMethod)
            {
                IsBackground = true
            };

            t.Start();

            Console.ReadKey();
        }
    }
}
