using System;
using System.Text.RegularExpressions;

namespace Listing_2_94
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
            var names = new[]
            {
                "Mr. Henry Hunt",
                "Ms. Sara Norris",
                "Abraham Adams",
                "Ms. Nicole Norris"
            };

            foreach (var name in names)
            {
                Console.WriteLine(Regex.Replace(name, pattern, string.Empty));
            }

            Console.ReadKey();
        }
    }
}
