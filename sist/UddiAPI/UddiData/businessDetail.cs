//
// Classe utilizada para o businessDetail
//
namespace SiST.UddiAPI.UddiData
{
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class businessDetail 
	{
		[System.Xml.Serialization.XmlElementAttribute("businessEntity")]
		public businessEntity[] businessEntity;

		[System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string generic;

		[System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string @operator;

		[System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool truncated;

		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool truncatedSpecified;
	}
} 