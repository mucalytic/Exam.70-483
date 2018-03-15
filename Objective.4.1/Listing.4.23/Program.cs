using System;
using System.IO;
using System.Threading.Tasks;

namespace Listing_4_23
{
    public class Program
    {
        // writing asynchronously to a file
        public static async Task Main(string[] args)
        {
            var random = new Random();
            var path = Path.Combine(Environment.CurrentDirectory, "test.dat");

            using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, Convert.ToInt32(Math.Pow(2, 12))))
            {
                var bytes = new byte[100_000];

                random.NextBytes(bytes);

                await stream.WriteAsync(bytes, 0, bytes.Length);
            }
        }
    }
}
