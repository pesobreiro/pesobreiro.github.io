//
// Classe utilizada para a serialização da mensagem
// save_business
//
namespace SiST.UddiAPI.UddiMensagem
{
	using System.Xml.Serialization;
	using SiST.UddiAPI.UddiData;

	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class save_business 
	{
			public string authInfo;

			[System.Xml.Serialization.XmlElementAttribute("businessEntity")]
			public SiST.UddiAPI.UddiData.businessEntity businessEntity;
	}
}