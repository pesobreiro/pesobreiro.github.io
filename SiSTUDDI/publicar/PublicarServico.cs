using System;
using SiSTUddi.xml;
using SiSTUddi.administrar;

namespace SiSTUddi.publicar
{
	/// <summary>
	/// Esta classe permite publicar informação relativamente
	/// às empresas que se pretendem registrar.                            
	/// </summary>
	public class PublicarServico
	{
		public PublicarServico()
		{
			// Parametros gerais

		}
		/// <summary>
		/// Registrar o servico
		/// </summary>
		/// <param name="businessKey">Identificacao da empresa onde se pretende adicionar os servicos</param>
		public void Registrar(string businessKey, string keyName, string keyValue)
		{
			string mensagem;
			/*
			try
			{
				Serializador serializador = new Serializador();


				mensagem = serializador.saveService(businessKey,keyName,keyValue, Parametros.UNSPSC);

				save_business sb = new save_business();

				mensagem = serializador.enviarSocket("localhost",sb,false);

			}
			catch (Exception e)
			{Console.WriteLine("UDDI exception: " + e.Message);}*/
		}
		/// <summary>
		/// Actualizar a base de dados
		/// </summary>
		/// <param name="businessKey"></param>
		private void ActualizarBD(int userID,string businessKey)
		{
			Empresa empresa = new Empresa();

			empresa.Criar(userID,businessKey);
			
		}

		/// <summary>
		/// Eliminar o servico
		/// </summary>
		public void Eliminar(string businessKey, string authInfo, string nomeServico)
		{
			try
			{
				Servicos servico = new Servicos();
				SiST.UddiCliente.SerializadorXML sXML = new SiST.UddiCliente.SerializadorXML();
				SiST.UddiCliente.DeserializadorXML dsXML = new SiST.UddiCliente.DeserializadorXML();

				//Eliminar a informacao ao servidor UDDI
				string resultado = sXML.getBusinessDetail(businessKey);
				SiST.UddiAPI.UddiData.businessDetail bd = dsXML.getBusinessDetail(resultado);

				//Determinar o category bag
				SiST.UddiAPI.UddiData.keyedReference[] categoryBag = bd.businessEntity[0].categoryBag;
                SiST.UddiAPI.UddiData.keyedReference[] novaCategoryBag = new SiST.UddiAPI.UddiData.keyedReference[categoryBag.Length];
				int i = 0;
				foreach (SiST.UddiAPI.UddiData.keyedReference kr in categoryBag)
				{
					if (nomeServico != kr.keyName)
					{
						novaCategoryBag[i] = new SiST.UddiAPI.UddiData.keyedReference();
						novaCategoryBag[i].keyName = kr.keyName;
						novaCategoryBag[i].keyValue = kr.keyValue;
						novaCategoryBag[i].tModelKey = kr.tModelKey;
						i++;
					}
				}

				bd.businessEntity[0].categoryBag = novaCategoryBag;

				//Gravar a business Entity sem a classificacao
				sXML.saveBusiness(authInfo , bd.businessEntity[0]);

				//Eliminar a informacao da Base de Dados
				string serviceID = servico.ObterServiceID(nomeServico);
				servico.Eliminar(businessKey,serviceID);
			}
			catch (Exception e)
			{
				Console.WriteLine("General exception: " + e.Message);
			}
		}

		private void ProcurarTipoServico()
		{
			//Em construcao
		}
	}
}
