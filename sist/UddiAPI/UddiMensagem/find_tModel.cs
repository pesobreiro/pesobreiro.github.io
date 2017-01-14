//
// Classe utilizada para a serialização da mensagem
// find_tModel
//
namespace SiST.UddiAPI.UddiMensagem
{
	using UddiAPI.UddiData;

	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class find_tModel
	{

		public string findQualifiers;

		public string name;

		[System.Xml.Serialization.XmlElementAttribute("categoryBag")]
		public UddiAPI.UddiData.keyedReference categoryBag;

		public string tModelBag;
	}
}
