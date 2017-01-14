/// <summary>
/// Esta classe utiliza a classe uddi_v2.cs que foi gerada a partir do schema xsd
/// da versao 2.0 do UDDI
///  
/// Classe que faz a serialização da classe taxonomias para um ficheiro xml
/// para ser enviado para o servidor como uma mensagem SOAP...
/// 
/// </summary>
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

using System.Net;
using System.Net.Sockets;

using SiSTUddi.xml;

namespace SiSTUddi.administrar
{
	public class Serializador
	{
		string dir = @"c:\inetpub\wwwroot\SiSTUDDI\administrar\";
		XmlSerializer serializa;
		TextWriter gravaXML;

		public Serializador()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Adiciona o cabecalho SOAP e a Formatacao
		/// </summary>
		/// <param name="nomeFicheiro"></param>
		/// <returns></returns>
		private string AdicionarCabecalho(object classeUddi)
		{
			// Define as variáveis e uma string para escrever para o servidor

			TextReader tr = new StreamReader(dir + classeUddi.ToString() + ".xml");

			string mensagem = "";
			string linha;
			//Para cada linha do ficheiro ler e adicionar a String resultante
			//Vou passar a primeira linha
			mensagem = @"<s:Envelope xmlns:s='http://schemas.xmlsoap.org/soap/envelope/'>" + "\r\n";
			mensagem = mensagem + @"<s:Body>" +"\r\n";
			tr.ReadLine();

			while ((linha = tr.ReadLine()) != null)
			{
				mensagem = mensagem + linha + "\r\n";
			}
			mensagem = mensagem + @"</s:Body>" + "\r\n";
			mensagem = mensagem + @"</s:Envelope>";

			//Fecha o reader
			tr.Close();
		
			//Gravar as alterações
			gravaXML = new StreamWriter(dir + classeUddi.ToString() + ".xml");
			gravaXML.Write(mensagem);
			gravaXML.Close();

			return mensagem;
		}
		/// <summary>
		/// Envio da mensagem para o servidor via Sockets
		/// </summary>
		/// <param name="server">Nome Servidor</param>
		/// <param name="mensagem">Mensagem SOAP a enviar</param>
		/// <param name="tipo">Tipo de operacao true-pesquisar ou false-publicar</param>
		/// <returns></returns>
		public string enviarSocket(string server, object classeUddi, bool tipo) 
		{
			Encoding ASCII = Encoding.ASCII;
			string mensagem = "";
			string linha;

			//Obtem a mensagem SOAP			
			TextReader tr = new StreamReader(dir + classeUddi.ToString() + ".xml");
			while ((linha = tr.ReadLine()) != null)
			{
				mensagem = mensagem + linha + "\r\n";
			}


			//Definir a operacao
			string operacao;
			if (tipo) 
			{
				operacao = "/uddisoap/inquiryapi";
			} 
			else 
			{
				operacao = "/uddisoap/publishapi";
			}

			//Adiciona cabecalho HTTP
			//Enviar a mensagem

			mensagem = "POST " + operacao + " HTTP/1.0\r\n" +
				"User-Agent: Sample UDDI agent\r\n" +
				"Content-Type: text/xml; charset=\"utf-8\"\r\n" +
				"Content-length: " + mensagem.Length + "\r\n"	 + 
				"SOAPAction: " + "\"\"" + "\r\n" +
				"\r\n" +
				mensagem +
				"\r\n";

			
			Byte[] ByteGet = ASCII.GetBytes(mensagem);
			Byte[] RecvBytes = new Byte[256];
			String strRetPage = null;


			// IPAddress e IPEndPoint representam para onde vai ser enviado
			// a mensagem SOAP
			// Obter o primeiro endereço ip atraves da resolucao DNS.
			IPAddress hostadd = Dns.Resolve(server).AddressList[0];
			IPEndPoint EPhost = new IPEndPoint(hostadd, 9080);
 
			//Cria o Socket para enviar os dados via TCP.
			Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
				ProtocolType.Tcp );
 
			// liga ao host através IPEndPoint.
			s.Connect(EPhost);
			if (!s.Connected)
			{
				strRetPage = "Unable to connect to host";
			}
 
			// Envia o POST para o host.
			s.Send(ByteGet, ByteGet.Length, SocketFlags.None);
 
			// Recebe a página de resposta 
			Int32 bytes = s.Receive(RecvBytes, RecvBytes.Length, 0);
			strRetPage = "Default HTML page on " + server + ":\r\n";
			strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
 
			while (bytes > 0)
			{
				bytes = s.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None);
				strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
			}

			//return mensagem;
			return strRetPage; //Texto retornado no servidor
		}
		/// <summary>
		/// Envio da mensagem via HTTP
		/// </summary>
		/// <param name="server">Nome Servidor</param>
		/// <param name="mensagem">Mensagem SOAP a enviar</param>
		private void enviarHTTP(string server, object classeUddi) 
		{
			// Initializa o WebRequest.
			WebRequest myRequest = WebRequest.Create("http://www.contoso.com");

			// Obtem a resposta. 
			WebResponse myResponse = myRequest.GetResponse();


			// Code to use the WebResponse goes here.

			// liberta o canal.
			myResponse.Close();
		}
	/// <summary>
	///  Adiciona o atributos necessários através do DOM, para enviar a mensagem formatada conforme
	///  especificação do UDDI server. 
	///  
	/// </summary>
	/// <param name="classeUddi"></param>
		private void DefinirAtributos(object classeUddi)
		{
			TextReader tr = new StreamReader(dir + classeUddi.ToString() + ".xml");
		
			XmlDocument doc = new XmlDocument();
			doc.Load(tr);
			// vou adicionar o atributo generic.
			XmlAttribute attr = doc.CreateAttribute("generic");
			attr.Value = "2.0";
			doc.DocumentElement.SetAttributeNode(attr);

			tr.Close();
			//Gravar as alterações
			gravaXML = new StreamWriter(dir + classeUddi.ToString() + ".xml");
			doc.Save(gravaXML);
			gravaXML.Close();
		}

		/// <summary>
		/// Grava o ficheiro XML da Classe
		/// </summary>
		private string GravaXML(object classeUddi)
		{
			gravaXML = new StreamWriter(dir + classeUddi.ToString() + ".xml");
			serializa.Serialize(gravaXML,classeUddi);

            gravaXML.Close();

			DefinirAtributos(classeUddi);
			//Adiciona o cabeçalho SOAP
            return AdicionarCabecalho(classeUddi);
		}

		/// <summary>
		/// Criar mensagem SOAP para find Business
		/// </summary>
		public string findBusiness(string nome)
		{
			find_business fb = new find_business();
			fb.name = nome;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(find_business));

			return GravaXML(fb);
		}

		/// <summary>
		/// Criar mensagem SOAP para find service
		/// </summary>
		public string findService(string nome)
		{
			find_service fs = new find_service();
			fs.name = nome;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(find_service));

			return GravaXML(fs);
		}

		/// <summary>
		/// Criar mensagem SOAP para find tmodel
		/// </summary>
		public string findtModel(string nome)
		{

			find_tModel ftm = new find_tModel();
			ftm.name = nome;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(find_tModel));

			return GravaXML(ftm);
		}

		public string saveService(string businessKey, string keyName, string keyValue, string tModelKey)
		{
			businessEntity empresa = new businessEntity();
			empresa.businessKey = businessKey; //Tenho de enviar isto para atribuir um id

			//Construir o category bag
			keyedReference[] categorybag = new keyedReference[1];
			categorybag[0] = new keyedReference();
		
			categorybag[0].keyName = keyName;
			categorybag[0].keyValue = keyValue;
			categorybag[0].tModelKey = tModelKey;

			empresa.categoryBag = categorybag; //Adicionar o category bag a businessEntity

			businessEntity[] empresas = new businessEntity[1];
			empresas[0] = new businessEntity();
			empresas[0]  = empresa;

			//Tenho que enviar o authinfo
			save_business sb = new save_business();
			sb.businessEntity = empresas;
			sb.authInfo = "db2admin";


			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(save_business));

			return GravaXML(sb);
		}
	}
}