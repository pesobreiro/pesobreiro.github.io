namespace SiST.UddiAPI.UddiMensagem
{
	/// <summary>
	/// Classe utilizada para a serializacao da mensagem delete service
	/// </summary>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class delete_service
	{
		/// <summary>
		/// Token(autorizacao) para eliminar o servico
		/// </summary>
 		[System.Xml.Serialization.XmlElementAttribute("authInfo")]
		public string authInfo;
		/// <summary>
		/// serviceKey do servico a eliminar
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("serviceKey")]
		public string serviceKey;

	}

}
