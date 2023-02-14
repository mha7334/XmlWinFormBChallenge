
using System.Globalization;
using System.Xml.Serialization;

namespace WebOrderLib
{
    [XmlRoot("WebOrder")]
    public class WebOrder
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("Customer")]
        public string Customer { get; set; }

        [XmlIgnore]
        public DateTime Date { get; set; }

        [XmlElement("Date")]
        public string DateString
        {
            get
            {
                return Date.ToString("yyyyMMdd");
            }
            set
            {
                Date = DateTime.ParseExact(value,
                                         "yyyyMMdd",
                                         CultureInfo.InvariantCulture);
            }
        }

        [XmlArray("Items")]
        [XmlArrayItem("Item")]
        public WebOrderItem[]? Items { get; set; }


        public decimal AveragePrice
        {
            get
            {
                return Items.Select(i => i.Price).Average();

            }
        }

        public decimal TotalPrice
        {
            get
            {
                return Items.Select(i => i.Price * i.Quantity).Sum();
            }
        }
    }
}
