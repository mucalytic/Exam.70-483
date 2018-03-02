using System;
using System.Threading;

namespace Listing_1_01
{
    public class Program
    {
        private static void ThreadMethod()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(0);
            }
        }

        // creating a thread with the Thread class
        public static void Main(string[] args)
        {
            var t = new Thread(ThreadMethod);

            t.Start();

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }

            t.Join();

            Console.ReadKey();
        }
    }
}
