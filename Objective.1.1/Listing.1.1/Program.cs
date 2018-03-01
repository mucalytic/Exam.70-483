using System;
using System.Threading;

namespace Listing_1_1
{
    public class Program
    {
        public static void ThreadMethod()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(0);
            }
        }

        public static void Start(string[] args)
        {
            var t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }

            t.Join();
        }
    }
}
