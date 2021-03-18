using System;
using System.Xml;

//Meu UDDI
using SiST;
using SiST.UddiCliente;
using SiST.UddiAPI.UddiData;


namespace SiSTUddi.pesquisa
{
	/// <summary>
	/// Esta classe permite realizar a pesquisa de empresas
	/// pelo nome, por codigo de classificacao de actividade e por produtos
	/// ou serviços comercializados
	/// </summary>
	public class Pesquisa
	{
		// BusinessList pertence ao elemento business Info e retorna informação
		// da empresa e do UDDI.
		//public	BusinessList listaEmpresas;

		const string UNSPSC31 = "UUID:DB77450D-9FA8-45D4-A7BC-04411D14E384";

		public XmlDocument XMLDoc;

		/// <summary>
		/// Pesquisar por nome
		/// </summary>
		/// <param name="nomeEmpresa">String ou substring da empresa que se pretende pesquisar</param>
		/// <returns>Empresas Encontradas</returns>
		public businessEntity[] PesquisarNome(string nomeEmpresa)
		{
			SerializadorXML sXML = new SiST.UddiCliente.SerializadorXML();
			DeserializadorXML dsXML = new SiST.UddiCliente.DeserializadorXML();
			string resposta = sXML.findBusiness(nomeEmpresa);
			businessEntity[] bes = dsXML.findBusiness(resposta);
			
			return bes;
		}
		

		/// <summary>
		/// Pesquisa por servico
		/// </summary>
		/// <param name="nomeServico"></param>
		/// <returns>Empresas encontradas</returns>
		public businessEntity[] ProcurarServico(string idServico)
		{
			SerializadorXML sXML = new SiST.UddiCliente.SerializadorXML();
			DeserializadorXML dsXML = new SiST.UddiCliente.DeserializadorXML();

			string resposta = sXML.findBusinessCategory("%",Pesquisa.UNSPSC31,idServico.Trim());
			businessEntity[] bes = dsXML.findBusiness(resposta);

			return bes;
		}

		//Construir um metodo para pesquisa por nome e servico
	}
}
