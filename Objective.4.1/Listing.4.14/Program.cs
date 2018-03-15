using System;
using System.IO;
using System.Text;

namespace Listing_4_14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var stream = File.Create(Path.Combine(Environment.CurrentDirectory, "test.dat")))
            {
                var bytes = Encoding.UTF8.GetBytes("Test value!");

                stream.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
