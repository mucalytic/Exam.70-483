using System;
using System.IO;

namespace Listing_1_77
{
    public class Program
    {
        private delegate TextWriter CovarianceDel();

        // covariance with delegates (objects that inherit from the same thing)
        public static void Main(string[] args)
        {
            CovarianceDel del = MethodStream;

            del += MethodString;
            del();

            Console.ReadKey();
        }

        private static StreamWriter MethodStream() => null;

        private static StringWriter MethodString() => null;
    }
}
