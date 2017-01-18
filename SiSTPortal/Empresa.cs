using System;
using System.Data;
using System.Data.SqlClient;

using SiST;
using SiST.UddiCliente;
using SiST.UddiAPI;
using SiST.UddiAPI.UddiMensagem;
using SiST.UddiAPI.UddiData;

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
			SqlConnection cnn = new SqlConnection("server=sist.esdrm.pt;uid=sa;pwd=sa;database=SiST");
			cnn.Open();
			// Cria e Executa o SqlCommand
			string strSelect = "select EmpClass_Empresa_BusinessKey, EmpClass_Empresa_Utilizador_ID, " + 
							   "EmpClass_Class_ID   from EmpClass where EmpClass_Class_ID = " + CategoriaId;

			dataAdapter = new SqlDataAdapter(strSelect,cnn); 
			
			dataSet = new DataSet();
			dataAdapter.Fill(dataSet,"EmpClass");
			
			dataTable = dataSet.Tables["EmpClass"];
			SqlCommand cmd = new SqlCommand(strSelect ,cnn);
			cnn.Close();
			return dataTable;
		}

		public businessEntity[] obterEmpresastModel(string tModelValue)
		{
			//Determinar o nome da empresa
			SerializadorXML sXML = new SerializadorXML();
			DeserializadorXML dsXML = new DeserializadorXML();

			string doc = sXML.findBusinesstModel(tModelValue);
            businessEntity[] bes = dsXML.findBusiness(doc);
			return bes;
		}
		/// <summary>
		/// Obter os dados da empresa
		/// </summary>
		/// <param name="EmpresaID">business Key da empresa</param>
		/// <returns>Informacao da empresa</returns>
		public businessDetail ObterDetalhe(string businessKey)
		{
			//Determinar o nome da empresa
			SerializadorXML sXML = new SerializadorXML();
			DeserializadorXML dsXML = new DeserializadorXML();
			string resultado = sXML.getBusinessDetail(businessKey);
			businessDetail bd = dsXML.getBusinessDetail(resultado);
							
			return bd;
		}
	}
}
