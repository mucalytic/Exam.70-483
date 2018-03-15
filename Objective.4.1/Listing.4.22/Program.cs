using System;
using System.IO;
using System.Net;

namespace Listing_4_22
{
    public class Program
    {
        // executing a web request
        public static void Main(string[] args)
        {
            var request = WebRequest.Create("http://www.microsoft.com");

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        Console.WriteLine(reader.ReadToEnd());
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
