namespace SiST.UddiAPI.UddiData
{
	/// <summary>
	/// Classe utilizada para a serializacao do tModel
	/// </summary>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class tModel 
	{
		/// <summary>
		/// Elemento necessário, quando se grava deve ser enviada uma string vazia
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string tModelKey;

		/// <summary>
		/// Informacao de quem publicou a informacao do tModel, nao deve ser enviada quando se grava o tModel
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string authorizedName;

		/// <summary>
		/// Nome o operador que forneceu o tMode, nao deve ser enviada quando se grava o tModel
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string @operator;
		/// <summary>
		/// Nome do tModel
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("name")]
		public string name;

		[System.Xml.Serialization.XmlElementAttribute("description")]
		public string description;

		/// <summary>
		/// Descricao acerca do tModel
		/// </summary>
		[System.Xml.Serialization.XmlElementAttribute("overviewDoc")]
		public overviewDoc overviewDoc;

		/// <summary>
		/// Elemento que permite classificar o tModel
		/// </summary>
		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public keyedReference[] identifierBag;

		/// <summary>
		/// Relaciona o tModel com uma taxonomia
		/// </summary>
		[System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
		public keyedReference[] categoryBag;
	}
}
