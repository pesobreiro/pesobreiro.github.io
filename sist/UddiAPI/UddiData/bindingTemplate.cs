//
// Classe utilizada para a serialização da mensagem
// bindingTemplate
//
namespace SiST.UddiAPI.UddiData
{
	/// <summary>
	/// Descricao tecnica dos web services 
	/// </summary>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class bindingTemplate 
	{
		/// <summary>
		/// Identificador de um bindingTemplate
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute("bindingKey")]
		public string bindingKey;

		/// <summary>
		/// Identificacao do Business service
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute("serviceKey")]
		public string serviceKey;

		/// <summary>
		/// Descricao do web services
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("description")]
		public string description;
		
		/// <summary>
		/// Ponto de entrada para o web service:
		///	http; mailto; https; ftp; fax; phone e other.
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("accessPoint")]
		public accessPoint accessPoint;
		
		/// <summary>
		/// Encaminhar um binding template para outro bindingTemplate
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("hostingRedirector")]
		public string hostingRedirector;

		/// <summary>
		/// 
		/// </summary>
		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public tModelInstanceInfo[] tModelInstanceDetails;
	}
}
