//
// Classe utilizada para a serialização da mensagem
// save_service
//
namespace SiST.UddiAPI.UddiMensagem
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class save_service
	{

		public string authInfo;

		[System.Xml.Serialization.XmlElementAttribute("businessService")]
		public UddiAPI.UddiData.businessService businessService;
	}
}