using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_14
{
    public class Program
    {
        // using Task.WaitAll
        public static void Start(string[] args)
        {
            var tasks = new Task[3];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
            });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
            });

            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
            });

            Task.WaitAll(tasks);

            Console.ReadKey();
        }
    }
}
