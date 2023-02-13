using System.Xml.Serialization;

namespace WebOrderLib
{
    public class ProcessingService
    {
        public WebOrder Process(string file)
        {

            if (!File.Exists(file))
                throw new FileNotFoundException("Missing Xml file");

            var xmlString = File.ReadAllText(file);

            var serializer = new XmlSerializer(typeof(WebOrder));

            using (var reader = new StringReader(xmlString))
            {
                var webOrder = (WebOrder)serializer.Deserialize(reader);

                return webOrder;
            }
        }
    }
}
