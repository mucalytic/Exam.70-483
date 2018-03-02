using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Listing_1_18
{
    public class Program
    {
        // async and await
        public static async Task Main(string[] args)
        {
            Console.WriteLine(await DownloadContent());
            Console.ReadKey();
        }

        private static async Task<string> DownloadContent()
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync("http://www.microsoft.com");
            }
        }
    }
}
