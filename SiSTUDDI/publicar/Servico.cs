using System;
using System.Data;
using System.Data.SqlClient;
using SiST.UddiCliente;
using SiST.UddiAPI.UddiData;

namespace SiSTUddi.administrar
{
	/// <summary>
	/// Interface para os servicos na base de dados
	/// </summary>
	public class Servicos
	{
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
		public string ObterServiceKey(string nome, string businessKey)
		{
			SerializadorXML sXML = new SerializadorXML();
			DeserializadorXML dsXML = new DeserializadorXML();
			string resultado = sXML.findServiceName(nome, businessKey);
			serviceInfo[] servico = dsXML.findService(resultado);
			
			return servico[0].serviceKey;
		}

		/// <summary>
		/// Obtem o serviceID 
		/// </summary>
		/// <param name="nome">Nome do servico</param>
		/// <returns>O serviceID</returns>
		public string ObterServiceID(string nome)
		{
			// Cria e Abre a SqlConnection
			SqlConnection cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();
			// Cria e Executa o SqlCommand
			string strSelect = "select class_id, class_nome from Classificacao where class_descricao = '" + nome + "'";

			SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect,cnn); 
			
			DataSet dataSet = new DataSet();
			DataAdapter.Fill(dataSet,"Classificacao");
			
			DataTable dataTable = dataSet.Tables["Classificacao"];

			//Obter o valor do data table
			DataRow dr = dataTable.Rows[0];
			
			cnn.Close();

			return dr["class_id"].ToString().Trim();
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

				SerializadorXML sXML = new SerializadorXML();
				DeserializadorXML dsXML = new DeserializadorXML();
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

		/// <summary>
		/// Elimina um servico da Base de Dados
		/// </summary>
		/// <param name="businessKey">Identificacao da empresa criada no registry</param>
		/// <returns>Catch de um Exception</returns>
		public string Eliminar(string businessKey, string serviceID)
		{
			string resultadoOperacao = "";

			SqlConnection sqlConn;
			SqlCommand cmdDelete;

			string cmdSQLEmpClass = "delete EmpClass where EmpClass_Empresa_BusinessKey ='" + businessKey + "' "+									"and EmpClass_Class_ID = '" + serviceID + "'";

			sqlConn = new SqlConnection(Parametros.strConexaoBD);

			//Introduzir o codigo para eliminar os dados - Ver livro new ridders
			// Actualizar o SqlServer
			try
			{
				//Apagar as empresas da tabela empclass
				cmdDelete = new SqlCommand(cmdSQLEmpClass,sqlConn);
				sqlConn.Open();
				cmdDelete.ExecuteNonQuery();
				sqlConn.Close();
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

			return resultadoOperacao;
		}
	}
}