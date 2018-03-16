using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Listing_4_73
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "data.bin");
            var formatter = new BinaryFormatter();

            using (var stream = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(stream, new Person
                {
                    Id = 1,
                    Name = "Aaron Pina"
                });
            }

            using (var stream = new FileStream(path, FileMode.Open))
            {
                var person = (Person)formatter.Deserialize(stream);

                Debugger.Break();
            }
        }
    }
}
