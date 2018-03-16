using System;
using System.IO;
using System.Xml.Serialization;

namespace Listing_4_70
{
    public class Program
    {
        // serialising an object with ObjectSerializer
        public static void Main(string[] args)
        {
            var serialiser = new XmlSerializer(typeof(Person));

            using (var writer = new StringWriter())
            {
                serialiser.Serialize(writer, new Person
                {
                    FirstName = "Aaron",
                    LastName = "Pina",
                    Age = 42
                });

                var xml = writer.ToString();

                Console.WriteLine(xml);

                using (var reader = new StringReader(xml))
                {
                    var person = (Person)serialiser.Deserialize(reader);

                    Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old");
                }
            }

            Console.ReadKey();
        }
    }
}
