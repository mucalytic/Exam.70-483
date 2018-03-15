using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Listing_4_24
{
    public class Program
    {
        // executing an asynchronous HTTP request
        public static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                Console.WriteLine(await client.GetStringAsync("http://www.microsoft.com"));
            }

            Console.ReadKey();
        }
    }
}
