using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_45
{
    public class Program
    {
        // setting a timeout on a task
        public static void Main(string[] args)
        {
            var task = Task.Run(() =>
            {
                Console.WriteLine("Task start");
                Thread.Sleep(TimeSpan.FromSeconds(10));
                Console.WriteLine("Task stop");
            });

            var index = Task.WaitAny(new[] { task }, TimeSpan.FromSeconds(1));
            if (index == -1)
            {
                Console.WriteLine("Task timed out");
            }

            Console.ReadKey();
        }
    }
}
