using System;
using System.Data;
using System.Data.SqlClient;
using SiSTUddi.xml;

using System.Xml;
using System.Xml.Serialization;
// Static Model

namespace SiSTUddi.administrar
{
	public class Servicos
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
		/// Publica o servico no registry
		/// 
		/// Estou a desenvolver a mensagem que vai ser enviada ao servidor
		/// </summary>
		public void PublicarServico(string businessKey)
		{
			name[] nomeServico;
			description[] descricaoServico;
			contact[] contactosEmpresa;


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
			XmlSerializer serializa = new XmlSerializer(typeof(save_business));

			//return GravaXML(sb);
	
	

			//Enviar a informacao para ser publicada no servidor
			//Invocação de um metodo no serializador para publicacao da das taxonomias
			/*string nome = this.txtNome.Text;
			string descricao = this.txtDescricao.Text;
			int caracterizacao = this.rbCaracterizacao.SelectedIndex;*/

			//criar o ficheiro xml 

			Serializador serializador = new Serializador();
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
		/// Obtem os servicos registados por uma empresa
		/// </summary>
		/// <param name="Empresa"></param>
		/// <returns></returns>
		public DataTable ObterServicos(string empresa)
		{
			// Cria e Abre a SqlConnection
			SqlConnection cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();

			// Obtem o codigo do elemento seleccionado
			string strSelect = "select EmpClass_Empresa_ID, class_descricao from EmpClass " +
							   "inner join Classificacao on EmpClass_Class_ID = Class_ID where " +  
							   "EmpClass_Empresa_ID = " + System.Convert.ToInt16(empresa.Trim(),10);

			SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect,cnn); 
			DataSet dataSet = new DataSet();
			DataAdapter.Fill(dataSet,"Servicos");
			DataTable dataTable = dataSet.Tables["Servicos"];
			SqlCommand cmd = new SqlCommand(strSelect ,cnn);

			cnn.Close();

			return dataTable;
		}

		/// <summary>
		/// Actualiza a base de dados e adiciona ao registry
		/// </summary>
		/// <param name="businessKey">Registrar um servico na Empresa</param>
		/// <returns></returns>
		public string RegistrarServico(string businessKey,string empresaId, string userId, string keyName, string keyValue)
		{
			int IdEmpresa = Convert.ToInt16(empresaId,10);
			int IdUser = Convert.ToInt16(userId,10);
			string IdClass = keyValue.Trim();

			//Actualizar a base de dados
			string resultadoOperacao = "";
/*			string cmdSQL = "select * from EmpClass";

			SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdSQL, Parametros.strConexaoBD);
			SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);

			DataSet ds = new DataSet("myDs");
			dataAdapter.Fill(ds, "EmpClass"); //Cria uma datatable User
			DataTable dataTableUser = ds.Tables["EmpClass"];

			// Cria uma nova linha a define os valores
			DataRow dr = ds.Tables["EmpClass"].NewRow();
			dr["EmpClass_Empresa_ID"] = IdEmpresa;
			dr["EmpClass_Empresa_Utilizador_ID"] = IdUser;
			dr["EmpClass_Class_ID"] = IdClass;

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

*/
			//Adicionar ao Registry
			/*Código para publicar no registry*/
			string mensagem;
			try
			{
				Serializador serializador = new Serializador();
				mensagem = serializador.saveService(businessKey,keyName,keyValue, Parametros.UNSPSC);
				save_business sb = new save_business();
				mensagem = serializador.enviarSocket("localhost",sb,false);
			}
			catch (Exception e)
			{Console.WriteLine("UDDI exception: " + e.Message);}

			return resultadoOperacao;
		}






	}
}