//
// Classe utilizada para a serialização da mensagem
// tModelKey
//
namespace SiST.UddiAPI.UddiData
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class tModelInfo
	{
		[System.Xml.Serialization.XmlAttributeAttribute("tModelKey")]
		public string tModelKey;

		[System.Xml.Serialization.XmlElementAttribute("name")]
		public string name;

		[System.Xml.Serialization.XmlElementAttribute("description")]
		public string description;

	}
}