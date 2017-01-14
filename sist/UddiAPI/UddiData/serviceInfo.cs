//
// Classe utilizada para o tratamento da servicelist
//
namespace SiST.UddiAPI.UddiData
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class serviceInfo
	{
		[System.Xml.Serialization.XmlAttributeAttribute("serviceKey")]
		public string serviceKey;

		[System.Xml.Serialization.XmlAttributeAttribute("businessKey")]
		public string businessKey;

		[System.Xml.Serialization.XmlElementAttribute("name")]
		public string name;
	}
}