using System;
using System.Threading.Tasks;

namespace Listing_1_10
{
    public class Program
    {
        // adding a continuation
        public static void Start(string[] args)
        {
            var t = Task.Run(() =>
            {
                return 42;
            })
            .ContinueWith(i =>
            {
                return i.Result * 2;
            });

            Console.Write(t.Result);
            Console.ReadKey();
        }
    }
}
