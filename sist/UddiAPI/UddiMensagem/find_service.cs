namespace SiST.UddiAPI.UddiMensagem
{
	using UddiAPI.UddiData;

	/// <summary>
	/// Classe utilizada para a serializacao da mensagem find_service
	/// </summary>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class find_service
	{
		[System.Xml.Serialization.XmlAttributeAttribute("businessKey")]
		public string businessKey;

		public string findQualifiers;

		public string name;

		[System.Xml.Serialization.XmlElementAttribute("categoryBag")]
		public keyedReference categoryBag;

		public string tModelBag;

	}

}
