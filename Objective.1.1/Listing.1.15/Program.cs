using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_15
{
    public class Program
    {
        // using Task.WaitAny
        public static void Main(string[] args)
        {
            var tasks = new Task<int>[3];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(2000);
                return 1;
            });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 2;
            });

            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(3000);
                return 3;
            });

            while (tasks.Length > 0)
            {
                var i = Task.WaitAny(tasks);
                var task = tasks[i];

                Console.WriteLine(task.Result);

                tasks =
                    tasks
                        .ToList()
                        .Except(new[]
                        {
                            tasks[i]
                        })
                        .ToArray();
            }

            Console.ReadKey();
        }
    }
}
