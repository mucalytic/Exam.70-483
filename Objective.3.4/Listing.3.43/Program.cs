using System;
using System.Diagnostics;

namespace Listing_3_43
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Aaron",
                LastName = "Pina"
            };

            Debugger.Break();
            Console.ReadKey();
        }
    }
}
