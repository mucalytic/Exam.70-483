using System;
using System.Threading;

namespace Listing_1_3
{
    public class Program
    {
        private static void ThreadMethod(object o)
        {
            for (var i = 0; i < (int)o; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(0);
            }
        }

        // using ParameterizedThreadStart
        public static void Main(string[] args)
        {
            var t = new Thread(ThreadMethod);
            t.Start(5);
            t.Join();

            Console.ReadKey();
        }
    }
}
