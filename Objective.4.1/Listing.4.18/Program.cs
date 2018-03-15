using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Listing_4_18
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var compressed = Path.Combine(Environment.CurrentDirectory, "compressed.dat.gz");
            var uncompressed = Path.Combine(Environment.CurrentDirectory, "uncompressed.dat");
            var data = Enumerable.Repeat(Convert.ToByte('a'), Convert.ToInt32(Math.Pow(1024, 2))).ToArray();

            using (var stream = File.Create(uncompressed))
            {
                stream.Write(data, 0, data.Length);
            }

            using (var stream = File.Create(compressed))
            using (var gzip = new GZipStream(stream, CompressionMode.Compress))
            {
                gzip.Write(data, 0, data.Length);
            }

            Console.WriteLine($"Uncompressed: {new FileInfo(uncompressed).Length} bytes");
            Console.WriteLine($"Compressed: {new FileInfo(compressed).Length} bytes");
            Console.ReadKey();
        }
    }
}
