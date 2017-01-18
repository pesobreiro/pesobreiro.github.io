using System;

namespace SiST.UddiAPI.UddiData
{
	/// <summary>
	/// Identifica o ponto de acesso para o web service
	/// </summary>
	[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:uddi-org:api_v2")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:uddi-org:api_v2", IsNullable=false)]
	public class accessPoint 
	{
        
		/// <summary>
		/// Enumeracao de URLTypes
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute("URLType")]
		public URLType URLType;
        
		/// <summary>
		/// Localizacao do serviço definido em URLType
		/// ex. mailto: user@subdominio.dominio ou http://subdominio.dominio/local
		/// </summary>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value;
	}
}
