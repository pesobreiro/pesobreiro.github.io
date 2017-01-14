using System;
using System.Data;
using System.Data.SqlClient;

namespace SiSTUddi.publicar
{
	/// <summary>
	/// Summary description for Empresa.
	/// </summary>
	public class Empresa
	{
		SqlDataAdapter dataAdapter;
		DataTable dataTableUser;
		DataSet ds;
		public Empresa()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		/// <summary>
		/// Obtem as empresas registradas pelo utilizador
		/// </summary>
		/// <param name="Utilizador"></param>
		public DataTable ObterEmpresas(string idUtilizador)
		{
			int idUser = System.Convert.ToInt16(idUtilizador,10);
			// Cria e Abre a SqlConnection
			SqlConnection cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();
			// Cria e Executa o SqlCommand
			string strSelect = "select Empresa_ID from Empresa where Empresa_Utilizador_ID = " + idUser;

			SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect,cnn); 
			
			DataSet dataSet = new DataSet();
			DataAdapter.Fill(dataSet,"Empresa");
			
			DataTable dataTable = dataSet.Tables["Empresa"];
			SqlCommand cmd = new SqlCommand(strSelect ,cnn);
			cnn.Close();
			return dataTable;
		}			
		/// <summary>
		/// 
		/// </summary>
		/// <param name="idEmpresa"></param>
		/// <returns>BusinessKey</returns>
		public string ObterBusinessKey(string idEmpresa)
		{
			int IdEmpresa = System.Convert.ToInt16(idEmpresa,10);
			// Cria e Abre a SqlConnection
			SqlConnection cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();
			// Cria e Executa o SqlCommand
			string strSelect = "select Empresa_BusinessKey from Empresa where Empresa_ID = " + IdEmpresa;

			SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect,cnn); 
			
			DataSet dataSet = new DataSet();
			DataAdapter.Fill(dataSet,"Empresa");
			
			DataTable dataTable = dataSet.Tables["Empresa"];

			//Obter o valor do data table
			DataRow dr = dataTable.Rows[0];
			
			cnn.Close();

			return dr["Empresa_BusinessKey"].ToString();
		}
		/// <summary>
		/// Cria um registro da empresa adicionada pelo utilizador
		/// </summary>
		/// <param name="utilizador">Identificacao do utilizador que adicionou a empresa</param>
		/// <param name="businessKey">Identificacao da empresa criada no registry</param>
		/// <returns>Catch de um Exception</returns>
		public string CriarEmpresa(int utilizador, string businessKey)
		{
			string resultadoOperacao = "";
			string cmdSQL = "select * from Empresa";

			dataAdapter = new SqlDataAdapter(cmdSQL, Parametros.strConexaoBD);
			SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);

			ds = new DataSet("myDs");
			dataAdapter.Fill(ds, "Empresa"); //Cria uma datatable User
			dataTableUser = ds.Tables["Empresa"];

			// Cria uma nova linha a define os valores
			DataRow dr = ds.Tables["Empresa"].NewRow();
			dr["Empresa_Utilizador_ID"] = utilizador;
			dr["Empresa_BusinessKey"] = businessKey;

			//Adiciona a nova linha á tabela
			dataTableUser.Rows.Add(dr);

			// Actualizar o SqlServer
			try
			{
				dataAdapter.Update(ds, "Empresa");
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
