using System;
using System.Threading.Tasks;

namespace Listing_1_10
{
    public class Program
    {
        // adding a continuation
        public static void Main(string[] args)
        {
            var t =
                Task.Run(() => 42)
                    .ContinueWith(i => i.Result * 2);

            Console.Write(t.Result);
            Console.ReadKey();
        }
    }
}
