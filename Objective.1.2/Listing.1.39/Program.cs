using System;
using System.Threading;

namespace Listing_1_39
{
    public class Program
    {
        // a potential problem with multithreaded code
        private static volatile int flag;
        private static int value;

        private static void Thread1()
        {
            value = 5;
            flag = 1;
        }

        private static void Thread2()
        {
            if (flag == 1)
            {
                Console.WriteLine(value);
            }
        }

        public static void Main(string[] args)
        {
            new Thread(Thread1).Start();
            new Thread(Thread2).Start();

            Console.ReadKey();
        }
    }
}
