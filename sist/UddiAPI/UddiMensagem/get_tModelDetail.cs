//
// Classe utilizada para a serialização da mensagem
// get_tModelDetail
//
namespace SiST.UddiAPI.UddiMensagem
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class get_tModelDetail
	{
		public string tModelKey;
	}
}
