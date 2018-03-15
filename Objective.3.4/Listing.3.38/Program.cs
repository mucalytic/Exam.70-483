using System;
using System.Diagnostics;

namespace Listing_3_38
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Debugger.Break();
            
            #line 200 "OtherFileName"
            int a;
            #line default
            int b;
            #line hidden
            int c;
            int d;

            Debugger.Break();
            Console.ReadKey();
        }
    }
}
