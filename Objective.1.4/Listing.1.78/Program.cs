using System;
using System.IO;

namespace Listing_1_78
{
    public class Program
    {
        private delegate void ContravarianceDel(StreamWriter writer);

        // contravariance will delegates
        public static void Main(string[] args)
        {
            ContravarianceDel del = DoSomething;

            del(null);

            Console.ReadKey();
        }

        private static void DoSomething(TextWriter writer) { }
    }
}
