using System;
using System.Data;
using System.Data.SqlClient;


// Static Model

namespace SiSTUddi.administrar
{
	public class Taxonomia
	{

		private string nome;

		private string tModelKey;

		private bool validada;

		private bool categoria;

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
		/// Obtem todas as taxonomias
		/// </summary>
		/// <returns>Datatable do tipo classificacao</returns>
		public DataTable obterTaxonomias()
		{
			// Cria e Abre a SqlConnection
			SqlConnection cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();
			// Cria e Executa o SqlCommand
			string strSelect = "select class_id, class_descricao from Classificacao ";

			SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect,cnn); 
			
			DataSet dataSet = new DataSet();
			DataAdapter.Fill(dataSet,"Classificacao");
			
			DataTable dataTable = dataSet.Tables["Classificacao"];
			SqlCommand cmd = new SqlCommand(strSelect ,cnn);
			cnn.Close();
			return dataTable;
		}

		public DataTable obterTaxonomias(string descricao)
		{
			string codBase = "";
			// Cria e Abre a SqlConnection
			SqlConnection cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();

			// Obtem o codigo do elemento seleccionado
			string strSelect = "select class_id, class_descricao from Classificacao " + 
				"where class_descricao = '" + descricao.Trim() + "'";

			SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect,cnn); 
			DataSet dataSet = new DataSet();
			DataAdapter.Fill(dataSet,"Classificacao");
			DataTable dataTable = dataSet.Tables["Classificacao"];
			SqlCommand cmd = new SqlCommand(strSelect ,cnn);

			foreach ( DataRow dataRow in dataTable.Rows)
			{
				codBase = dataRow["class_id"].ToString();
			}

			
			// Cria e Executa o SqlCommand
			strSelect = "select class_id, class_descricao from Classificacao " + 
							   "where class_parent = '" + codBase.Trim() + "'";

			DataAdapter = new SqlDataAdapter(strSelect,cnn); 
			
			dataSet = new DataSet();
			DataAdapter.Fill(dataSet,"Classificacao");
			
			dataTable = dataSet.Tables["Classificacao"];
			cmd = new SqlCommand(strSelect ,cnn);
			cnn.Close();
			return dataTable;
		}
		
		/// <summary>
		/// Obtem o codigo de uma descricao da taxonomia
		/// </summary>
		/// <param name="descricao">Nome da taxonomia</param>
		/// <returns>Identificacao da taxonomia</returns>
		public string CodigoTaxonomia(string descricao)
		{
			string idTaxonomia = "";

			// Cria e Abre a SqlConnection
			SqlConnection cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();

			// Obtem o codigo do elemento seleccionado
			string strSelect = "select class_id, class_descricao from Classificacao " + 
				"where class_descricao = '" + descricao.Trim() + "'";

			SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect,cnn); 
			DataSet dataSet = new DataSet();
			DataAdapter.Fill(dataSet,"Classificacao");
			DataTable dataTable = dataSet.Tables["Classificacao"];
			SqlCommand cmd = new SqlCommand(strSelect ,cnn);

			foreach ( DataRow dataRow in dataTable.Rows)
			{
				idTaxonomia = dataRow["class_id"].ToString();
			}
			return idTaxonomia;
		}

	}// END CLASS DEFINITION Taxonomia
}