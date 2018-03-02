using System;
using System.Threading.Tasks;

namespace Listing_1_12
{
    public class Program
    {
        // attaching child tasks to a parent task
        public static void Main(string[] args)
        {
            var parent = Task.Run(() =>
            {
                var results = new int[3];

                new Task(() => results[0] = 0,
                    TaskCreationOptions.AttachedToParent).Start();

                new Task(() => results[1] = 1,
                    TaskCreationOptions.AttachedToParent).Start();

                new Task(() => results[2] = 2,
                    TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            var task = parent.ContinueWith(t =>
            {
                foreach (var i in t.Result)
                {
                    Console.WriteLine(i);
                }
            });

            task.Wait();

            Console.ReadKey();
        }
    }
}
