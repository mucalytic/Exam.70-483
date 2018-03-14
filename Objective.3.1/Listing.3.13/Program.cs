using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace Listing_3_13
{
    public class Program
    {
        public static string Location => Path.Combine(Environment.CurrentDirectory, "Data.json");

        public static void Main(string[] args)
        {
            var obj = JsonConvert.DeserializeObject<object>(File.ReadAllText(Location));

            Debugger.Break();
            Console.ReadKey();
        }
    }
}
