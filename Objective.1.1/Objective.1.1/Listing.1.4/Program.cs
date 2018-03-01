using System;
using System.Threading;

namespace Listing_1_4
{
    public class Program
    {
        // stopping a thread
        public static void Start(string[] args)
        {
            var stopped = false;
            var t = new Thread(new ThreadStart(() =>
            {
                while(!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }

                Console.WriteLine("Exiting...");
            }));

            t.Start();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;

            t.Join();
        }
    }
}
