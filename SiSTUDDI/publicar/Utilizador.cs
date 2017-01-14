using System;
using System.Data;
using System.Data.SqlClient;

namespace SiSTUddi.publicar
{
	/// <summary>
	/// Summary description for Utilizador.
	/// </summary>
	public class Utilizador
	{
		SqlDataAdapter dataAdapter;
		DataTable dataTableUser;
		//DataRow dr;
		DataSet ds;

		public Utilizador()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Cria o utilizador na base de dados
		/// </summary>
		/// <param name="Username"></param>
		/// <param name="Password"></param>
		/// <param name="Nome"></param>
		/// <param name="eMail"></param>
		/// <param name="Morada"></param>
		/// <param name="Localidade"></param>
		/// <param name="CodigoPostal"></param>
		/// <param name="Pais"></param>
		/// <returns>Resultado Operacao</returns>
		public string CriarUtilizador(string userName, string password, string Nome, string eMail, 
									string Morada, string Localidade, string CodigoPostal, string Pais)	{
			
			string resultadoOperacao = "";
			
			if (VerificaUtilizador(userName,password)) {
				resultadoOperacao = "Já existe o utilizador, escolha outro nome de utilizador!";
			}
			else {
				string cmdSQL = "select * from Utilizador";

				dataAdapter = new SqlDataAdapter(cmdSQL, Parametros.strConexaoBD);
				SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);

				ds = new DataSet("myDs");
				dataAdapter.Fill(ds, "Utilizador"); //Cria uma datatable User
				dataTableUser = ds.Tables["Utilizador"];

				// Cria uma nova linha a define os valores
				DataRow dr = ds.Tables["Utilizador"].NewRow();
				dr["Utilizador_Username"] = userName;
				dr["Utilizador_Password"] = password;
				dr["Utilizador_Nome"] = Nome;
				dr["Utilizador_eMail"] = eMail;
				dr["Utilizador_Morada"] = Morada;
				dr["Utilizador_Localidade"] = Localidade;
				dr["Utilizador_CodigoPostal"] = CodigoPostal;
				dr["Utilizador_Pais"] = Pais;
				dr["Utilizador_Activo"] = false;

				//Adiciona a nova linha á tabela
				dataTableUser.Rows.Add(dr);

				// Update SqlServer
				try
				{
					dataAdapter.Update(ds, "Utilizador");
				}
				catch (SqlException  ex)
				{
					resultadoOperacao = ex.ToString();
					//dataAdapter.
				}
			}
			return resultadoOperacao;
		}

		private bool VerificaUtilizador(string userName, string password)
		{
			SqlConnection cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();

			SqlCommand cmd = new SqlCommand("Select * from utilizador where Utilizador_Username ='" + 
										    userName + "'",cnn);
			SqlDataReader dr = cmd.ExecuteReader();
			bool achei;
			if (dr.Read()) {
				achei = true;
			}
			else{
				achei = false;
			}
			dr.Close();
			cnn.Close();

			return achei;
		}
	}
}
