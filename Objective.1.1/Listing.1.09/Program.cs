using System;
using System.Threading.Tasks;

namespace Listing_1_9
{
    public class Program
    {
        // using a task that returns a value
        public static void Main(string[] args)
        {
            var t = Task.Run(() => 42);

            Console.Write(t.Result);
            Console.ReadKey();
        }
    }
}
