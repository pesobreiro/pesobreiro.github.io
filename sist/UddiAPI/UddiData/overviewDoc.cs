namespace SiST.UddiAPI.UddiData
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class overviewDoc 
	{
		[System.Xml.Serialization.XmlElementAttribute("description")]
		public string description;

		public string overviewURL;
	}
}
