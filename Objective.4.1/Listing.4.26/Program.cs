using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Listing_4_26
{
    public class Program
    {
        // executing multiple requests in parallel
        public static async Task Main(string[] args)
        {
            const string main = "http://www.microsoft.com";
            const string msdn = "http://msdn.microsoft.com";
            const string blog = "http://blogs.msdn.com";

            var stopwatch = Stopwatch.StartNew();

            using (var client = new HttpClient())
            {
                var t1 = client.GetStringAsync(blog).ContinueWith(t => Console.WriteLine($"{blog} => {stopwatch.Elapsed}"));
                var t2 = client.GetStringAsync(msdn).ContinueWith(t => Console.WriteLine($"{msdn} => {stopwatch.Elapsed}"));
                var t3 = client.GetStringAsync(main).ContinueWith(t => Console.WriteLine($"{main} => {stopwatch.Elapsed}"));

                await Task.WhenAll(t1, t2, t3);
            }

            stopwatch.Stop();
            Console.ReadKey();
        }
    }
}
