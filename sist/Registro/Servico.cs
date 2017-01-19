using SiST.UddiCliente;
using SiST.UddiAPI.UddiData;

namespace SiST.Registro
{

	public class Servico
	{
		private string serviceKey;
		private string nome;
		SerializadorXML sXML;
		DeserializadorXML dsXML;

		/// <summary>
		/// Construtor Servico - Inicializacao
		/// </summary>
		public Servico()
		{
			sXML = new SiST.UddiCliente.SerializadorXML();
			dsXML = new SiST.UddiCliente.DeserializadorXML();
		}

		public void Criar()
		{
			
		}

		/// <summary>
		/// Eliminar um servico
		/// </summary>
		/// <param name="authInfo">token</param>
		/// <param name="businessKey">businessKey</param>
		public string Eliminar(string authInfo, string serviceKey)
		{
			string resultado = sXML.deleteService(authInfo,serviceKey);
			return resultado;
		}


		public void Alterar()
		{
			
		}

	}
} 
