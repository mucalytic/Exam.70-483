using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Listing_4_72
{
    [Serializable]
    public class Order
    {
        [XmlAttribute]
        public int Id { get; set; }

        [XmlIgnore]
        public bool IsDirty { get; set; }

        [XmlArray("Lines")]
        [XmlArrayItem("OrderLine")]
        public List<OrderLine> OrderLines { get; set; }
    }
}
