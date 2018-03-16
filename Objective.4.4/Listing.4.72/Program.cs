using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace Listing_4_72
{
    public class Program
    {
        // using XML attributes to configure serialisation
        public static void Main(string[] args)
        {
            var serialiser = new XmlSerializer(typeof(Order), new[] { typeof(VipOrder) });

            using (var writer = new StringWriter())
            {
                serialiser.Serialize(writer, new VipOrder
                {
                    Id = 4,
                    Description = "Order for Aaron Pina. Use nice gift-wrap.",
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Id = 5,
                            Amount = 1,
                            Product = new Product
                            {
                                Id = 1,
                                Description = "p1",
                                Price = 9
                            }
                        },
                        new OrderLine
                        {
                            Id = 6,
                            Amount = 10,
                            Product = new Product
                            {
                                Id = 2,
                                Description = "p2",
                                Price = 6
                            }
                        }
                    }
                });

                var xml = writer.ToString();

                Console.WriteLine(xml);

                using (var reader = new StringReader(xml))
                {
                    var order = (Order)serialiser.Deserialize(reader);

                    Debugger.Break();
                }
            }
        }
    }
}
