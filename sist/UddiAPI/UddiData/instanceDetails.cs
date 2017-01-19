//
// Classe utilizada para a serialização da mensagem
// instanceDetails
//
namespace SiST.UddiAPI.UddiData
{
	/// <summary>
	/// Informacao sobre os detalhes para compreender a implementacao do servico
	/// relativamente ao tModelKey
	/// </summary>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class instanceDetails 
	{
		/// <summary>
		/// Descricao do objectivo do servico
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("description")]
		public string description;

		/// <summary>
		/// Informacao de como utilizar o servico
		/// </summary>
		public SiST.UddiAPI.UddiData.overviewDoc overviewDoc;

		/// <summary>
		/// URL que contem a referencia ao ficheiro que contem as 
		/// parametrizacoes e configuracoes necessárias.
		/// </summary>
		public string instanceParms;
	}
}
