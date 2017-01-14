//
// Classe utilizada para a serialização da mensagem
// tModelInstanceInfo
//
namespace SiST.UddiAPI.UddiData
{
	/// <summary>
	/// Descricao do Access Point e de como pode ser utilizado
	/// </summary>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class tModelInstanceInfo 
	{
		/// <summary>
		/// Identificao do tModel que descreve o tipo de servico
		/// ex. uuid:93335d49-3efb-48a0-acea-ea102b60ddc6 para protocolo HTTP
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute("tModelKey")]
		public string tModelKey;

		/// <summary>
		/// Descricao do papel que o tModel  representa na descricao do web service
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("description")]
		public string description;

		/// <summary>
		/// Informacao de suporte que permite descrever como utilizar o web
		/// service. 
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("instanceDetails")]
		public instanceDetails instanceDetails;
	}
}