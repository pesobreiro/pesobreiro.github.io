using System;
using System.Data;
using System.Data.SqlClient;

namespace SiSTPortal
{
	/// <summary>
	/// Summary description for Empresa.
	/// </summary>
	public class Empresa
	{
		SqlDataAdapter dataAdapter;
		DataTable dataTable;
		DataSet dataSet;
		public Empresa()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		/// <summary>
		/// Obtem as empresas registradas na Categoria
		/// </summary>
		/// <param name="Utilizador"></param>
		public DataTable ObterEmpresas(string CategoriaId)
		{
			// Cria e Abre a SqlConnection
			SqlConnection cnn = new SqlConnection("server=localhost;uid=sa;pwd=sa;database=SiST");
			cnn.Open();
			// Cria e Executa o SqlCommand
			string strSelect = "select EmpClass_Empresa_ID, EmpClass_Empresa_Utilizador_ID, " + 
							   "EmpClass_Class_ID   from EmpClass where EmpClass_Class_ID = " + EmpresaId;

			dataAdapter = new SqlDataAdapter(strSelect,cnn); 
			
			dataSet = new DataSet();
			dataAdapter.Fill(dataSet,"EmpClass");
			
			dataTable = dataSet.Tables["EmpClass"];
			SqlCommand cmd = new SqlCommand(strSelect ,cnn);
			cnn.Close();
			return dataTable;
		}
		/// <summary>
		/// Invocar o webservice e obter os dados da empresa
		/// </summary>
		/// <param name="EmpresaID"></param>
		/// <returns></returns>
		public DataTable ObterDetalhe(string EmpresaID)
		{

		}
	}
}
