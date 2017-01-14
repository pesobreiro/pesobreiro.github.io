namespace SiST.UddiAPI.UddiMensagem
{
	/// <summary>
	/// Classe utilizada para a serialização da mensagem
	/// get_serviceDetail
	/// </summary>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class get_serviceDetail
	{
		/// <summary>
		/// serviceKey do servico que se pretende obter os detalhes
		/// </summary>
		public string serviceKey;
	}
}