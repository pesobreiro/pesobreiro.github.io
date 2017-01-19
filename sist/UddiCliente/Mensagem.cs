/* Adicionar os cabeçalhos SOAP e formatação
 * necessária para enviar para o servidor
 * UDDI 
 */
using System;
using System.Xml;
using System.IO;

namespace SiST.UddiCliente
{
	/// <summary>
	/// Classe para realizar o empacotamento das mensagems serializadas
	/// </summary>
	public class Mensagem
	{
		public int tamanhoMensagem;
		public string mensagem;
		/// <summary>
		/// Formatar a mensagem a partir de um ficheiro
		/// </summary>
		/// <param name="pesquisa">Definir se e para publicacao ou pesquisa True=Pesquisa/False=Publicar</param>
		/// <param name="mensagem">Mensagem para formatar</param>
		/// <returns>Tamanho da mensagem</returns>
		public Mensagem (bool pesquisa, string docURL, XmlDocument xmlDoc)
		{
			//Definir os atributos
			this.DefinirAtributos(xmlDoc);

			xmlDoc.Save(docURL);
			//xmlDoc.Save();

			TextReader tr = new StreamReader(docURL);
			
			mensagem = tr.ReadLine() + "\r\n";

			//Adicionar Cabecalho SOAP
			mensagem = mensagem = @"<s:Envelope xmlns:s='http://schemas.xmlsoap.org/soap/envelope/'>" + "\r\n";
			mensagem = mensagem + @"<s:Body>" +"\r\n";

			mensagem = mensagem + tr.ReadToEnd();

			mensagem = mensagem + "\r\n" + @"</s:Body>" + "\r\n";
			mensagem = mensagem + @"</s:Envelope>";
			
			tr.Close();


			//Guardar as alteracoes
			try
			{
				xmlDoc.LoadXml(mensagem);
				xmlDoc.Save(docURL);
			}
			catch (Exception ex)
			{
				System.Console.WriteLine(ex);
			}

			//retornar o tamanho da mensagem
			tamanhoMensagem = mensagem.Length;
		}

		/// <summary>
		/// Formatar a mensagem a partir de um stream de memória
		/// </summary>
		/// <param name="pesquisa">Definir se e para publicacao ou pesquisa True=Pesquisa/False=Publicar</param>
		/// <param name="mensagem">Mensagem para formatar</param>
		/// <returns>Tamanho da mensagem</returns>
		public Mensagem (string msg)
		{
			XmlDocument xmlDoc = new XmlDocument();
			System.IO.MemoryStream memStream = new System.IO.MemoryStream();

			xmlDoc.LoadXml(msg);
			//Definir os atributos
			this.DefinirAtributos(xmlDoc);
			xmlDoc.Save(memStream);
			memStream.Seek(0,0);

			TextReader tr = new StreamReader(memStream);
			mensagem = tr.ReadLine() + "\r\n";
			//Adicionar Cabecalho SOAP
			mensagem = mensagem = @"<s:Envelope xmlns:s='http://schemas.xmlsoap.org/soap/envelope/'>" + "\r\n";
			mensagem = mensagem + @"<s:Body>" +"\r\n";
			mensagem = mensagem + tr.ReadToEnd();
			mensagem = mensagem + "\r\n" + @"</s:Body>" + "\r\n";
			mensagem = mensagem + @"</s:Envelope>";
			tr.Close();

			memStream.Close();
			tamanhoMensagem = mensagem.Length;
		}

		public XmlDocument DefinirAtributos(XmlDocument xmlDoc)
		{
			//Adicionar os atributos necessários ao documento
			//XML para que seja respeitada a especificação
			//UDDI (Via DOM)

			//Adicionar o atributo generic
			XmlAttribute atributo = xmlDoc.CreateAttribute("generic");
			atributo.Value = "2.0";
			xmlDoc.DocumentElement.SetAttributeNode(atributo);

			return xmlDoc;
		}
	}
} 
