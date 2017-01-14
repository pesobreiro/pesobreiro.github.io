using System;
using SiSTUddi.xml;
using SiSTUddi.administrar;

namespace SiSTUddi.publicar
{
	/// <summary>
	/// Esta classe permite publicar informação relativamente
	/// às empresas que se pretendem registrar.                            
	/// </summary>
	public class PublicarServico
	{
		public PublicarServico()
		{
			// Parametros gerais

		}
		/// <summary>
		/// Registrar o servico
		/// </summary>
		/// <param name="businessKey">Identificacao da empresa onde se pretende adicionar os servicos</param>
		public void Registrar(string businessKey, string keyName, string keyValue)
		{
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
		}
		/// <summary>
		/// Actualizar a base de dados
		/// </summary>
		/// <param name="businessKey"></param>
		private void ActualizarBD(int userID,string businessKey)
		{
			Empresa empresa = new Empresa();

			empresa.CriarEmpresa(userID,businessKey);
			
		}

		private void ProcurarTipoServico()
		{
			//Em construcao
		}
	}
}
