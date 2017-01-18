//
// Classe utilizada para a serialização da mensagem
// business Service
//
namespace SiST.UddiAPI.UddiData
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class businessService
	{
		[System.Xml.Serialization.XmlAttributeAttribute("serviceKey")]
		public string serviceKey;

		[System.Xml.Serialization.XmlAttributeAttribute("businessKey")]
		public string businessKey;

		[System.Xml.Serialization.XmlElementAttribute("name")]
		public name[] name;

		[System.Xml.Serialization.XmlElementAttribute("description")]
		public Description[] description;
		
		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public bindingTemplate[] bindingTemplates;

		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public keyedReference[] categoryBag;
	}
}