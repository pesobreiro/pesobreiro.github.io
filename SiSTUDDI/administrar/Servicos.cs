using System;
using System.Data;
using System.Data.SqlClient;
using SiSTUddi.xml;

// Static Model

namespace SiSTUddi.administrar
{
	public class Servicos
	{
		/*
		public static bool criar(string nome)
		{
		
		}

		public bool eliminar(string tmodel_key)
		{
		
		}

		public bool alterar(string tmodel_key)
		{
		
		}
		*/
		/// <summary>
		/// Publica o servico no registry
		/// 
		/// Estou a desenvolver a mensagem que vai ser enviada ao servidor
		/// </summary>
		public void PublicarServico(string businessKey)
		{
			businessEntity[] empresas = new businessEntity[1];
			empresas[0] = new businessEntity();
			//empresas[0]  = empresa;

			//Tenho que enviar o authinfo
			save_business sb = new save_business();
			sb.businessEntity = empresas;
			sb.authInfo = "db2admin";
			//sb.businessEntity = empresa;


			//Alterar enviar socket para publish e inquiry


			//Serializar o objecto para XML
			//XmlSerializer serializa = new XmlSerializer(typeof(save_business));

			//return GravaXML(sb);
	
	

			//Enviar a informacao para ser publicada no servidor
			//Invocação de um metodo no serializador para publicacao da das taxonomias
			/*string nome = this.txtNome.Text;
			string descricao = this.txtDescricao.Text;
			int caracterizacao = this.rbCaracterizacao.SelectedIndex;*/

			//criar o ficheiro xml 

			//Serializador serializador = new Serializador();
			/*txtMsg.Text = serializador.findtModel("%");

			//find_business fb = new find_business();
			find_tModel ftm = new find_tModel();			
			txtMsg.Text = serializador.enviarSocket("localhost",ftm);*/
		}

		public DataTable obterTaxonomias()
		{
			// Cria e Abre a SqlConnection
			SqlConnection cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();
			// Cria e Executa o SqlCommand
			string strSelect = "select class_code, class_descricao from Classificacao ";

			SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect,cnn); 
			
			DataSet dataSet = new DataSet();
			DataAdapter.Fill(dataSet,"Classificacao");
			
			DataTable dataTable = dataSet.Tables["Classificacao"];
			SqlCommand cmd = new SqlCommand(strSelect ,cnn);
			cnn.Close();
			return dataTable;
		}


		/// <summary>
		/// Obtem os servicos registados numa empresa
		/// </summary>
		/// <param name="businessKey">ID da empresa</param>
		/// <returns></returns>
		public DataTable ObterServicos(string businessKey)
		{
			// Cria e Abre a SqlConnection
			SqlConnection cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();

			// Obtem o codigo do elemento seleccionado
			string strSelect = "select EmpClass_Empresa_BusinessKey, class_descricao from EmpClass " +
							   "inner join Classificacao on EmpClass_Class_ID = Class_ID where " +  
							   "EmpClass_Empresa_BusinessKey = '" + businessKey.Trim() +"'";

			SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect,cnn); 
			DataSet dataSet = new DataSet();
			DataAdapter.Fill(dataSet,"Servicos");
			DataTable dataTable = dataSet.Tables["Servicos"];
			SqlCommand cmd = new SqlCommand(strSelect ,cnn);

			cnn.Close();

			return dataTable;
		}

		/// <summary>
		/// Obtem o service key
		/// </summary>
		/// <returns></returns>
		public string ObterServiceKey()
		{
			string teste="0";
			return teste;
		}

		/// <summary>
		/// Registra o servico, actualiza a base de dados e adiciona ao registry
		/// </summary>
		/// <param name="userId">Identificacao do utilizador que esta a registrar o servico</param>
		/// <param name="businessKey">Registrar um servico na Empresa do BusinessKey</param>
		/// <param name="nomeServico"></param>
		/// <param name="keyName">Descricao do servico</param>
		/// <param name="keyValue">Codigo do servico</param>
		/// <param name="tModelKey">TModelKey que idenfifica o tModel associado ao servico</param>
		/// <returns></returns>
		public string RegistrarServico(string userId,string token,string businessKey, string nomeServico, string keyName, string keyValue, string tModelKey)
		{
			string IdEmpresa = businessKey.Trim();
			int IdUser = Convert.ToInt16(userId,10);
			string IdClass = keyValue.Trim();

			//Actualizar a base de dados
			string resultadoOperacao = "";
			//Adicionar ao Registry
			/*Código para publicar no registry*/
			try
			{
				//Actualizar a base de dados
				string cmdSQL = "select * from EmpClass";

				SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdSQL, Parametros.strConexaoBD);
				SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);

				DataSet ds = new DataSet("myDs");
				dataAdapter.Fill(ds, "EmpClass"); //Cria uma datatable User
				DataTable dataTableUser = ds.Tables["EmpClass"];

				// Cria uma nova linha a define os valores
				DataRow dr = ds.Tables["EmpClass"].NewRow();
				dr["EmpClass_Empresa_BusinessKey"] = businessKey;
				dr["EmpClass_Empresa_Utilizador_ID"] = userId;
				dr["EmpClass_Class_ID"] = keyValue;

				//Adiciona a nova linha á tabela
				dataTableUser.Rows.Add(dr);

				// Actualizar o SqlServer
				try
				{
					dataAdapter.Update(ds, "EmpClass");
				}
				catch (SqlException  sqlEx)
				{
					resultadoOperacao = sqlEx.ToString();
					//dataAdapter.
				}
				catch (Exception ex)
				{
					resultadoOperacao = ex.ToString();
				}

				SiST.UddiCliente.SerializadorXML sXML = new SiST.UddiCliente.SerializadorXML();
				SiST.UddiCliente.DeserializadorXML dsXML = new SiST.UddiCliente.DeserializadorXML();
				resultadoOperacao = sXML.saveService(token,businessKey,nomeServico,"",keyName,keyValue,tModelKey);
				dsXML.saveService(resultadoOperacao);	
								
			}
			catch (Exception e)
			{
				resultadoOperacao = "UDDI exception: " + e.Message;
			}

			return resultadoOperacao;
		}

		/// <summary>
		/// Registra o interface para o servico 
		/// </summary>
		/// <param name="userId">Identificacao do utilizador que esta a registrar o servico</param>
		/// <param name="businessKey">Registrar um servico na Empresa do BusinessKey</param>
		/// <param name="nome">Nome do servico a registrar</param>
		/// <returns></returns>
		public string RegistrarServicoWeb(string token, string businessKey, string nome, string descricao, string tipoURL, string pontoAcesso, string descricaoPontoAcesso, string tModelKey, string descricaotModel, string urlDocPontoAcesso, string txtDocPontoAcesso )
		{
			//Actualizar a base de dados
			string resultadoOperacao = "";
			//Adicionar ao Registry
			/*Código para publicar no registry*/
			try
			{
				SiST.UddiCliente.SerializadorXML sXML = new SiST.UddiCliente.SerializadorXML();
				SiST.UddiCliente.DeserializadorXML dsXML = new SiST.UddiCliente.DeserializadorXML();
				resultadoOperacao = sXML.saveWebServiceSb(token,businessKey,nome,descricao,tipoURL,pontoAcesso,descricaoPontoAcesso,tModelKey,descricaotModel,urlDocPontoAcesso, txtDocPontoAcesso);
				dsXML.saveService(resultadoOperacao);	
			}
			catch (Exception e)
			{
				resultadoOperacao = "UDDI exception: " + e.Message;
			}

			return resultadoOperacao;
		}





	}
}