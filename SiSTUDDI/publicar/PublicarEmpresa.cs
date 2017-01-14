using System;
//UDDI
using SiST.Registro;

namespace SiSTUddi.publicar
{
	/// <summary>
	/// Esta classe permite publicar informação relativamente
	/// aos servicos  que se pretendem registrar.                            
	/// </summary>
	public class PublicarEmpresa
	{
		public PublicarEmpresa()
		{
			// Parametros gerais

		}
		
		/// <summary>
		/// Registrar a empresa
		/// </summary>
		/// <param name="nome"></param>
		/// <param name="descricao"></param>
		/// <param name="contacto"></param>
		/// <param name="funcaoContacto"></param>
		public void Registrar(int userID,string authInfo, string nome, string descricao, string contacto, string funcaoContacto,string keyName, string keyValue, string tModelKey)
		{
			try
			{
				//Adicionar a informacao ao servidor UDDI
				SiST.Registro.Empresa empresaUddi = new SiST.Registro.Empresa();
				string businessKey = empresaUddi.Criar(authInfo,nome,descricao,contacto,funcaoContacto,keyName,keyValue,tModelKey);
	
				//Actualizar a Base de dados com os dados adicionados ao UDDI.
				Empresa empresa = new Empresa();
				empresa.Criar(userID,businessKey);
			}
			catch (Exception e)
			{
				Console.WriteLine("General exception: " + e.Message);
			}
		}

		/// <summary>
		/// Eliminar a empresa
		/// </summary>
		/// <param name="userID">Id user Base de Dados</param>
		/// <param name="authInfo">Token</param>
		/// <param name="businessKey">businessKey a eliminar</param>
		public void Eliminar(string userID, string authInfo, string businessKey)
		{
			try
			{
				//Adicionar a informacao ao servidor UDDI
				SiST.Registro.Empresa empresaSiST = new SiST.Registro.Empresa();
				string resultado = empresaSiST.Eliminar(authInfo,businessKey);
	
				//Actualizar a base de dados
				Empresa empresa = new Empresa();
				empresa.Eliminar(userID,businessKey);
			}
			catch (Exception e)
			{
				Console.WriteLine("General exception: " + e.Message);
			}
		}


		private void ProcurarTipoServico()
		{
			//Em construcao
		}
	}
}
