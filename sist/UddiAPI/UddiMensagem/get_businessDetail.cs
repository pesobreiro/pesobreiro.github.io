namespace SiST.UddiAPI.UddiMensagem
{
	/// <summary>
	/// Classe utilizada para a serialização da mensagem
	/// get_BusinessDetail
	/// </summary>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class get_businessDetail
	{
		/// <summary>
		/// businessKey da empresa que se pretende obter os detalhes
		/// </summary>
		public string businessKey;
	}
} 