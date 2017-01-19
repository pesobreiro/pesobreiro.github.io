//
// Classe utilizada para a serialização da mensagem
// delete_tModel
//
namespace SiST.UddiAPI.UddiMensagem
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class delete_tModel
	{
		[System.Xml.Serialization.XmlElementAttribute("authInfo")]
		public string authInfo;

		[System.Xml.Serialization.XmlElementAttribute("tModelKey")]
		public string tModelKey;
	}
} 
