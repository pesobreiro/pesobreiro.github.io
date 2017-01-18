namespace SiST.UddiAPI.UddiMensagem
{
	/// <summary>
	/// Classe utilizada para a serializacao de mensagem delete_business
	/// </summary>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class delete_business
	{
		/// <summary>
		/// Token(autorizacao) para eliminar o empresa
		/// </summary>
		//[System.Xml.Serialization.XmlElementAttribute("authInfo")]
		public string authInfo;
		/// <summary>
		/// businessKey da empresa a eliminar
		/// </summary>
		//[System.Xml.Serialization.XmlElementAttribute("businessKey")]
		public string businessKey;
	}
}
