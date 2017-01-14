namespace SiST.UddiAPI.UddiData
{
	using System.Xml.Serialization;
	/*
	 * Classe para a serializacao de nomes
	 */
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class name 
	{
		[System.Xml.Serialization.XmlAttributeAttribute(Namespace="http://www.w3.org/XML/1998/namespace")]
		public const string lang = "pt";

		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value;
	}
}
