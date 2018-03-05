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
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    value = 2;
                }
            });

            var t2 = Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                value = 3;
            });

            Task.WaitAll(t1, t2);

            Console.WriteLine(value);
            Console.ReadKey();

            value = 1;

            var t3 = Task.Run(() =>
            {
                Interlocked.CompareExchange(ref value, 2, 1);
            });

            var t4 = Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                value = 3;
            });

            Task.WaitAll(t3, t4);

            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
