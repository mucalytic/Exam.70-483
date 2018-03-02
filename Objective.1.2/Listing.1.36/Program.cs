using System;
using System.Threading.Tasks;

namespace Listing_1_36
{
    public class Program
    {
        // using the lock keyword
        public static void Main(string[] args)
        {
            var locker = new object();
            var n = 0;
            var up = Task.Run(() =>
            {
                for (var i = 0; i < 10_000_000; i++)
                {
                    lock (locker)
                    {
                        n++;
                    }
                }
            });

            for (var i = 0; i < 10_000_000; i++)
            {
                lock (locker)
                {
                    n--;
                }
            }

            up.Wait();

            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
