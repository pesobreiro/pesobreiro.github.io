namespace SiST.UddiAPI.UddiData
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class contact 
	{
		[System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string useType;

		[System.Xml.Serialization.XmlElementAttribute("description")]
		public string description;

		[System.Xml.Serialization.XmlElementAttribute("personName")]
		public string personName;

		[System.Xml.Serialization.XmlElementAttribute("phone")]
		public string phone;

		[System.Xml.Serialization.XmlElementAttribute("email")]
		public string email;

		[System.Xml.Serialization.XmlElementAttribute("address")]
		public string address;
	}
}

