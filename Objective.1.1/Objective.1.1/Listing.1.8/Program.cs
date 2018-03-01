using System;
using System.Threading.Tasks;

namespace Listing_1_8
{
    public class Program
    {
        // starting a new task
        public static void Start(string[] args)
        {
            var t = Task.Run(() =>
            {
                for (var x = 0; x < 100; x++)
                {
                    Console.Write("*");
                }
            });

            t.Wait();

            Console.ReadKey();
        }
    }
}
