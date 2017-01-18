namespace SiST.UddiAPI.UddiData
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class Description 
	{

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(Namespace="http://www.w3.org/XML/1998/namespace")]
		public const string lang = "pt";

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value;
	}
}
