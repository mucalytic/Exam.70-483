using System;
using System.Xml.Serialization;

namespace Listing_4_72
{
    [Serializable]
    public class OrderLine
    {
        [XmlAttribute]
        public int Id { get; set; }

        [XmlAttribute]
        public int Amount { get; set; }

        [XmlElement("OrderedProduct")]
        public Product Product { get; set; }
    }
}
