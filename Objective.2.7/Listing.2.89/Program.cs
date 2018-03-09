using System;
using System.IO;
using System.Xml;

namespace Listing_2_89
{
    public class Program
    {
        // using a StringWriter as the output for an XmlWriter
        public static void Main(string[] args)
        {
            var stringWriter = new StringWriter();

            using (var xmlWriter = XmlWriter.Create(stringWriter))
            {
                xmlWriter.WriteStartElement("book");
                xmlWriter.WriteElementString("price", "19.95");
                xmlWriter.WriteEndElement();
                xmlWriter.Flush();
            }

            Console.WriteLine(stringWriter.ToString());
            Console.ReadKey();
        }
    }
}
