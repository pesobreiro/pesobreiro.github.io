namespace SiST.UddiAPI.UddiData
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class businessEntity 
	{
		[System.Xml.Serialization.XmlAttributeAttribute("businessKey")]
		public string businessKey;

		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public discoveryURL[] discoveryURLs;

		[System.Xml.Serialization.XmlElementAttribute("name")]
		public name[] name;

		[System.Xml.Serialization.XmlElementAttribute("description")]
		public Description[] description;

		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public contact[] contacts;

		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public businessService[] businessServices;

		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public keyedReference[] identifierBag;

		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public keyedReference[] categoryBag;
	}
}
