using System;
using System.IO;
using System.Text;

namespace Listing_4_16
{
    public class Program
    {
        // opening a FileStream and decoding the bytes to a string
        public static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "test.dat");

            using (var stream = File.Create(path))
            {
                var bytes = Encoding.UTF8.GetBytes("Test value!");

                stream.Write(bytes, 0, bytes.Length);
            }

            using (var stream = File.OpenRead(path))
            {
                var bytes = new byte[stream.Length];

                for (var i = 0; i < stream.Length; i++)
                {
                    bytes[i] = Convert.ToByte(stream.ReadByte());
                }

                Console.WriteLine(Encoding.UTF8.GetString(bytes));
            }

            Console.ReadKey();
        }
    }
}
