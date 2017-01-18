using System;
using System.Data;
using System.Data.SqlClient;

//Sessions
using System.Web;
using System.Web.SessionState;

namespace SiSTUddi.administrar
{
	/// <summary>
	/// Classe que valida o acesso dos utilizadores.
	/// </summary>
	public class VerificarAcesso
	{
		private bool AcessoValido;
		private int userID;
		private string userName;
		private string password;


		public int UserID
		{
			set
			{
				userID = value;
			}
			get
			{
				return userID;
			}
		}
		
		public string UserName
		{
			set
			{
				userName = value;
			}
			get
			{
				return userName;
			}
		}

		public string Password
		{
			set
			{
				password = value;
			}
			get
			{
				return password;
			}
		}

		public bool ValidarAcesso()
		{
			AcessoValido = false;
			// Cria e Abre a SqlConnection
			SqlConnection cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();
			// Cria e Executa o SqlCommand
			string strSelect = "select Utilizador_ID, Utilizador_Activo,Utilizador_Username from Utilizador " + 
							   "where (Utilizador_Username = '" + userName + "') AND " + 
							   "(Utilizador_Password = '" + password + "') AND " +
							   "(Utilizador_Activo = 1)" ;

			SqlCommand cmd = new SqlCommand(strSelect ,cnn);
			IDataReader dr = cmd.ExecuteReader();

			// Obtem os resultados
			if (dr.Read()) 
			{
				AcessoValido = true;
				
				//Obter o numero de utilizador
				int i = dr.GetOrdinal("Utilizador_ID");
				string temp = dr.GetValue(i).ToString();
				userID = System.Convert.ToInt16(temp,10);
				
								
				//Actualizar o ficheiro de logs com a data de entrada


			}
			else
			{
				AcessoValido = false;
			}

			dr.Close();
			cnn.Close();

			return AcessoValido;

		}

		public VerificarAcesso()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
