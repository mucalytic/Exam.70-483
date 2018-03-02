using System;
using System.Threading.Tasks;

namespace Listing_1_13
{
    public class Program
    {
        // using a TaskFactory
        public static void Main(string[] args)
        {
            var parent = Task.Run(() =>
            {
                var results = new int[3];
                var factory = new TaskFactory
                    (TaskCreationOptions.AttachedToParent,
                     TaskContinuationOptions.ExecuteSynchronously);

                factory.StartNew(() => results[0] = 0);
                factory.StartNew(() => results[1] = 1);
                factory.StartNew(() => results[2] = 2);

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
