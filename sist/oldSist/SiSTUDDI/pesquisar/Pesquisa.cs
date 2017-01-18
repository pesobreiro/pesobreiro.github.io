using System;
//UDDI
using Microsoft.Uddi;
using Microsoft.Uddi.Business;
using Microsoft.Uddi.Service;
using Microsoft.Uddi.Binding;
using Microsoft.Uddi.ServiceType;
using Microsoft.Uddi.Api;

namespace SiSTUddi.pesquisar
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
		public	BusinessList listaEmpresas;

		public Pesquisa()
		{
			Inquire.Url = "http://localhost:9080/uddisoap/inquiryapi";
		}

		/// <summary>
		/// Pesquisar por nome
		/// </summary>
		/// <param name="nomeEmpresa">String ou substring da empresa que
		/// se pretende pesquisar</param>
		public bool PesquisarNome(string nomeEmpresa)
		{
			SiST.UddiCliente.SerializadorXML sxml = new SiST.UddiCliente.SerializadorXML();
			sxml.findBusiness(nomeEmpresa);

			FindBusiness procuraEmpresa = new FindBusiness();
			procuraEmpresa.Names.Add(nomeEmpresa);
			try
			{
				//
				listaEmpresas = procuraEmpresa.Send();
				//Define rows e cells para a tabela

				if(listaEmpresas.BusinessInfos.Count > 0)
				{
					return true; //Pesquisa com resultados
				}
				else
				{
					return false; //Pesquisa sem resultados
				}
			}
			catch( Exception excepcao)
			{
				//Enviar mensagem para o utilizador
				Console.WriteLine(excepcao);
				return false;
			}
		}

		private void ProcurarTipoServico()
		{
			//Em construcao
		}
	}
}
