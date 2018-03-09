using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace Listing_2_90
{
    public class Program
    {
        // using a StringReader as the input for an XmlReader
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

            var stringReader = new StringReader(stringWriter.ToString());

            using (var xmlReader = XmlReader.Create(stringReader))
            {
                xmlReader.ReadToFollowing("price");

                if (decimal.TryParse(xmlReader.ReadInnerXml(), NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out var price))
                {
                    Console.WriteLine(price);
                }
            }

            Console.ReadKey();
        }
    }
}
