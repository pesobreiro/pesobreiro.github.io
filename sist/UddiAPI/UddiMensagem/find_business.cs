//
// Classe utilizada para a serialização da mensagem
// find_business
//
namespace SiST.UddiAPI.UddiMensagem
{
	using System.Xml.Serialization;
	using SiST.UddiAPI.UddiData;

	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class find_business
	{
		[System.Xml.Serialization.XmlElementAttribute("name")]
		public string name;

		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public discoveryURL[] discoveryURLs;

		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public keyedReference[] identifierBag;

		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public keyedReference[] categoryBag;

		[System.Xml.Serialization.XmlElementAttribute("tModelBag")]
		public string tModelBag;	
	}
}
