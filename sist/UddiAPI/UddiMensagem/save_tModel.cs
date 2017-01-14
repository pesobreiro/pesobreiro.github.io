//
// Classe utilizada para a serialização da mensagem
// save_tModel
//
namespace SiST.UddiAPI.UddiMensagem
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]	
	public class save_tModel
	{
		public string authInfo;

		[System.Xml.Serialization.XmlElementAttribute("tModel")]
		public UddiAPI.UddiData.tModel tModel;
	}
}
