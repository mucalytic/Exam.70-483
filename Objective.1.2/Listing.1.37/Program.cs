using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_37
{
    public class Program
    {
        // creating a deadlock
        public static void Main(string[] args)
        {
            var lockA = new object();
            var lockB = new object();
            var up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked A");

                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB)
            {
                Console.WriteLine("Locked B");
                Thread.Sleep(TimeSpan.FromSeconds(1));

                lock (lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }

            up.Wait();

            Console.ReadKey();
        }
    }
}
