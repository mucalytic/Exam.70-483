using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_41
{
    public class Program
    {
        private static int value = 1;

        // compare and exchange as a non-atomic operation
        public static void Main(string[] args)
        {
            var t1 = Task.Run(() =>
            {
                if (value == 1)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    value = 2;
                }
            });

            var t2 = Task.Run(() =>
            {
                value = 3;
            });

            Task.WaitAll(t1, t2);

            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
