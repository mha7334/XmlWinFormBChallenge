using System.Xml.Serialization;

namespace WebOrderLib
{
    [XmlType("Item")]
    public class WebOrderItem
    {

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("description")]
        public string Description { get; set; }

        [XmlElement("Price")]
        public decimal Price { get; set; }

        [XmlElement("Quantity")]
        public int Quantity { get; set; }

    }
}