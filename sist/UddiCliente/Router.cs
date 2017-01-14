/*
 * Classe responsável por enviar as mensagems XML
 * para o servidor UDDI
 */
using System;
using System.IO;
using System.Text;
using System.Net;
//utilizacao de socket para a captura da exception
using System.Net.Sockets;
using System.Xml;

namespace SiST.UddiCliente
{

	public class Router
	{

		private const string URLPublicar = "http://sist.esdrm.pt:9080/uddisoap/publishapi";
		
		private const string URLPesquisar = "http://sist.esdrm.pt:9080/uddisoap/inquiryapi";

		Parametros param;

		public Router()
		{
			param = new Parametros();
			
		}

		/// <summary>
		/// Metodo para o tratamento do erro na resposta HTTP
		/// </summary>
		/// <param name="pesquisa">true pesquisar / false publicar</param>
		/// <returns>Mensagem de erro</returns>
		string ErroResposta(bool pesquisa, string mensagemServer)
		{
			string server = "sist.esdrm.pt";
			string mensagem = mensagemServer; //Mensagem a enviar para o servidor
			string operacao; //operacao a realizar, publicar ou registrar

			String strRetPage = null;
			//Definicao do encoding como ASCII
			Encoding ASCII = Encoding.ASCII;

			if (pesquisa)
			{
				operacao = "/uddisoap/inquiryapi";
			}
			else
			{
				operacao = "/uddisoap/publishapi";
			}

			//Construir o cabecalho HTTP

			mensagem = "POST " + operacao + " HTTP/1.0\r\n" +
				"User-Agent: Sample UDDI agent\r\n" +
				"Content-Type: text/xml; charset=\"utf-8\"\r\n" +
				"Content-length: " + mensagem.Length + "\r\n"	 + 
				"SOAPAction: " + "\"\"" + "\r\n" +
				"\r\n" +
				mensagem +
				"\r\n";
			
			Byte[] ByteGet = ASCII.GetBytes(mensagem);
			Byte[] RecvBytes = new byte[256];

			//Obter o endereco IP
			IPAddress hostadd = Dns.Resolve(server).AddressList[0];
			IPEndPoint EPHost = new IPEndPoint(hostadd, 9080);

			//criar o socket para enviar os dados via TCP
			Socket socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);

			//Liga ao host pelo IPEndPoint
			socket.Connect(EPHost);
			if (!socket.Connected)
			{
				strRetPage = "Nao e possivel contactar o servidor";
			}

			//Envia o POST para o HOST
			socket.Send(ByteGet, ByteGet.Length, SocketFlags.None);

			//Recebe a pagina de resposta
			Int32 bytes = socket.Receive(RecvBytes, RecvBytes.Length,0);
			strRetPage = strRetPage + ASCII.GetString(RecvBytes,0,bytes);

			while (bytes > 0)
			{
				bytes = socket.Receive(RecvBytes,RecvBytes.Length,SocketFlags.None);
				strRetPage = strRetPage + ASCII.GetString(RecvBytes,0,bytes);
			}

			//Guardar o resultado
			XmlDocument doc = new XmlDocument();
			string resposta = strRetPage.Remove(0,181); //remove o cabecalho http

			//doc.LoadXml(resposta);

			//Retornar a resposta do servidor
			return resposta;
		}

		/// <summary>
		/// Metodo para fazer um pedido HTTP a partir de um ficheiro Xml
		/// </summary>
		/// <param name="pesquisa">true pesquisar / false publicar</param>
		/// <param name="mensagemServer">nome do objecto que foi serializado</param>
		/// <param name="tamanho">tamanho da mensagem que vai ser enviada para o servidor</param>
		/// <returns>String Resultado operacao</returns>
		public XmlDocument Enviar(bool pesquisa, string mensagemServer, int tamanho)
		{
			HttpWebRequest pedidoHttp;

			string resultado = null;


			// Inicializar o WebRequest para pesquisa ou publicar.
			if (pesquisa) 
			{
				pedidoHttp= (HttpWebRequest)WebRequest.Create(URLPesquisar);
			}
			else 
			{
				pedidoHttp= (HttpWebRequest)WebRequest.Create(URLPublicar);
			}

			//Carregar o ficheiro XML
			XmlDocument doc = new XmlDocument();
			doc.Load(param.ficheirosXml + mensagemServer);
						
			//Definir os parametros da mensagem a enviar
			pedidoHttp.Headers.Add("SOAPAction: \"\"");
			pedidoHttp.ContentType="text/xml;charset=\"utf-8\"";
			pedidoHttp.Accept="text/xml";
			pedidoHttp.Method="POST";

			string cab = pedidoHttp.Headers.ToString();
	
			try
			{
				//Criar um stream
				Stream stm = pedidoHttp.GetRequestStream();
				//Gravar o documento xml pelo Stream
				doc.Save(stm);
				stm.Close();


				//Obter a Resposta
				WebResponse respostaHttp = pedidoHttp.GetResponse();
				stm = respostaHttp.GetResponseStream();

				StreamReader sr = new StreamReader(stm);

				resultado = sr.ReadToEnd();

				//Guardar o resultado
				doc.LoadXml(resultado);

				doc.Save(param.ficheirosXml + "resposta.xml");
				Console.WriteLine(resultado);
				sr.Close();
			}
			catch (WebException wex)
			{
				//Tratamento do erro obtido na resposta
				//Analisar a tratar o erro em mensagem soap.
				string respostaServer = this.ErroResposta(pesquisa, mensagemServer);
			
				Console.WriteLine(wex.Message);
				Console.WriteLine(respostaServer);
			}
			catch (Exception ex)
			{
				//Tratamento do erro obtido na resposta
				//Analisar a tratar o erro em mensagem soap.
				resultado = ex.ToString();
				Console.WriteLine(resultado);
			}

			// Tratamento da resposta
			// Utilizacao do Deserializador XML

			return doc;
		}
		/// <summary>
		/// Metodo para fazer um pedido HTTP a partir de uma string
		/// </summary>
		/// <param name="pesquisa">true pesquisar / false publicar</param>
		/// <param name="mensagemServer">nome do objecto que foi serializado</param>
		/// <param name="tamanho">tamanho da mensagem que vai ser enviada para o servidor</param>
		/// <returns>String Resultado operacao</returns>
		public string EnviarStr(bool pesquisa, string mensagem, int tamanho)
		{
			HttpWebRequest pedidoHttp;

			string resultado = null;


			// Inicializar o WebRequest para pesquisa ou publicar.
			if (pesquisa) 
			{
				pedidoHttp= (HttpWebRequest)WebRequest.Create(URLPesquisar);
			}
			else 
			{
				pedidoHttp= (HttpWebRequest)WebRequest.Create(URLPublicar);
			}

			//Carregar o ficheiro XML
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(mensagem);
						
			//Definir os parametros da mensagem a enviar
			pedidoHttp.Headers.Add("SOAPAction: \"\"");
			pedidoHttp.ContentType="text/xml;charset=\"utf-8\"";
			pedidoHttp.Accept="text/xml";
			pedidoHttp.Method="POST";

			string cab = pedidoHttp.Headers.ToString();
	
			try
			{
				//Criar um stream
				Stream stm = pedidoHttp.GetRequestStream();
				//Gravar o documento xml pelo Stream
				doc.Save(stm);
				stm.Close();


				//Obter a Resposta
				WebResponse respostaHttp = pedidoHttp.GetResponse();
				stm = respostaHttp.GetResponseStream();

				StreamReader sr = new StreamReader(stm);

				resultado = sr.ReadToEnd();

				//Guardar o resultado
				//doc.LoadXml(resultado);

				//doc.Save(param.ficheirosXml + "resposta.xml");
				//Console.WriteLine(resultado);
				sr.Close();
			}
			catch (WebException wex)
			{
				//Tratamento do erro obtido na resposta
				//Analisar a tratar o erro em mensagem soap.
				Console.WriteLine(wex);
				resultado = this.ErroResposta(pesquisa, mensagem);
			}
			catch (Exception ex)
			{
				//Tratamento do erro obtido na resposta
				//Analisar a tratar o erro em mensagem soap.
				resultado = ex.ToString();
			}

			// Tratamento da resposta
			// Utilizacao do Deserializador XML

			return resultado;
		}

	}
}
