using System;
using System.Threading.Tasks;

namespace Listing_1_35
{
    public class Program
    {
        // accessing shared data in a multithreaded application
        public static void Main(string[] args)
        {
            var n = 0;
            var up = Task.Run(() =>
            {
                for (var i = 0; i < 10_000_000; i++)
                {
                    n++;
                }
            });

            for (var i = 0; i < 10_000_000; i++)
            {
                n--;
            }

            up.Wait();

            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
