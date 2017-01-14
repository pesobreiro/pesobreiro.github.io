using System;
using System.Data;
using System.Data.SqlClient;

namespace SiSTUddi.administrar
{
	/// <summary>
	/// Classe que permite o controle dos logs dos utilizadores
	/// </summary>
	public class Logs
	{
		private SqlConnection cnn;
		public Logs()
		{
			//
			// TODO: Add constructor logic here
			//
			// Cria e Abre a SqlConnection
			cnn = new SqlConnection(Parametros.strConexaoBD);
			cnn.Open();
		}

		// Define uma entrada no ficheiro de logs
		public void CriarEntrada()
		{
			// Cria e Executa o Insert para actualizar o log
			string strInsert = "select User_Username from user where (User_Username = '')" ;

			SqlCommand cmd = new SqlCommand(strInsert,cnn);
			IDataReader dr = cmd.ExecuteReader();
		}
	}
}
