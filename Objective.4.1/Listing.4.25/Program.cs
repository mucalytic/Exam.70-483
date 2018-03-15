using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Listing_4_25
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            const string main = "http://www.microsoft.com";
            const string msdn = "http://msdn.microsoft.com";
            const string blog = "http://blogs.msdn.com";

            var stopwatch = Stopwatch.StartNew();

            using (var client = new HttpClient())
            {
                await client.GetStringAsync(blog).ContinueWith(t => Console.WriteLine($"{blog} => {stopwatch.Elapsed}"));
                await client.GetStringAsync(msdn).ContinueWith(t => Console.WriteLine($"{msdn} => {stopwatch.Elapsed}"));
                await client.GetStringAsync(main).ContinueWith(t => Console.WriteLine($"{main} => {stopwatch.Elapsed}"));
            }

            stopwatch.Stop();
            Console.ReadKey();
        }
    }
}
