using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using SiST.UddiAPI.UddiData;
using SiST.UddiAPI.UddiMensagem;

namespace SiST
{
	/// <summary>
	/// Parametros globais da aplicacao.
	/// </summary>
	public class Parametros
	{
		string localFicheirosXml;
		string autenticacaoInfo;

		public Parametros()
		{
			//Obter a directoria
			localFicheirosXml = @"C:\Inetpub\wwwroot\SiSTUDDI\xml\";
			autenticacaoInfo  = "db2admin";
		}

		public string ficheirosXml
		{
			set
			{
				localFicheirosXml = value;
			}
			get
			{
				return localFicheirosXml;
			}
		}

		public string authInfo
		{
			set
			{
				autenticacaoInfo = value;
			}
			get
			{
				return autenticacaoInfo;
			}
		}
		
		public static void Main(string[] args)
		{

			SiST.UddiCliente.SerializadorXML sXML = new SiST.UddiCliente.SerializadorXML();
			SiST.UddiCliente.DeserializadorXML dsXML = new SiST.UddiCliente.DeserializadorXML();

			Console.WriteLine("Mensagens a invocar");
			Console.WriteLine("\t gt	- Obter Token");
			Console.WriteLine("\t fb	- Find Business");
			Console.WriteLine("\t fs	- Find Service");
			Console.WriteLine("\t ft	- Find tModel");
			Console.WriteLine("\t gbd	- Get Business Detail");
			Console.WriteLine("\t gtd	- Get Business Detail");
			Console.WriteLine("\t sb	- Save Business");
			Console.WriteLine("\t stm	- Save tModel");
			Console.WriteLine("\t d		- Save tModel Distritos");
			Console.WriteLine("\t db	- Delete Business");
			Console.WriteLine("\t dtm	- Delete tModel");
			Console.WriteLine("\t bs	- Save Service Identification");
			Console.WriteLine("\t ws	- Save Web Service");
			Console.WriteLine("\t ws_ss	- Save Web Service Save_Service");
			Console.WriteLine("\t dws	- Deserializar Save Web Service");
			Console.WriteLine("");
			string arg = Console.ReadLine();

			switch (arg)
			{
				case "fb":
					string doc = sXML.findBusiness("%");
					businessEntity[] bes = dsXML.findBusiness(doc);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					break;

				case "fbtm":
					doc = sXML.findBusinesstModel("distritos-pt:Coimbra");
					bes = dsXML.findBusiness(doc);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					break;


				case "gt":
					authToken token = sXML.obterToken("db2admin","baril");
					Console.WriteLine(token.authInfo);
					Console.ReadLine();
					break;

				case "stm":
					//Obter o toKen
					token = sXML.obterToken("xico","xico");
					doc = sXML.savetModel(token.authInfo, "Um tModel", "Este tModel e um exemplo","","","");
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					break;

				case "d":
					//Obter o toKen
					string url = "http://sist.esdrm.pt/portugal/distritos.html";
					token = sXML.obterToken("xico","xico");
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Aveiro", "Aveiro","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Acores", "Acores","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Beja", "Beja","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Braga", "Braga","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Braganca", "Braganca","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:CasteloBranco", "Castelo Branco","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Coimbra", "Coimbra","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Evora", "Evora","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Faro", "Faro","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Guarda", "Guarda","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Leiria", "Leiria","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Lisboa", "Lisboa","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Madeira", "Madeira","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Portalegre", "Portalegre","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Porto", "Porto","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Santarem", "Santarem","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Setubal", "Setubal","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Viana", "Viana do Castelo","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:VilaReal", "Vila Real","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					doc = sXML.savetModel(token.authInfo, "distritos-pt:Viseu", "Viseu","","Distritos de Portugal",url);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					break;

				case "dtm":
					//Obter o toKen
					token = sXML.obterToken("dbadmin","baril");
					doc = sXML.deletetModel(token.authInfo,"uuid:31572562-3858-4753-86D3-1CC12BA937BF");
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					break;

				case "db":
					//Obter o toKen
					token = sXML.obterToken("xico","xico");
					doc = sXML.deleteBusiness(token.authInfo,"32CE009C-145E-4DED-B6EA-144A15DC3D1A");
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					break;

				case "fs":
					doc = sXML.findServiceKey("15BFF8D9-105D-4F5F-8BDF-00F127970E67");
					//businessEntity[] bes = dsXML.findBusiness();
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					Console.WriteLine("Tratamento da resposta");
					serviceInfo[] si = new serviceInfo[1];
						
					si = dsXML.findService(doc);
					Console.WriteLine(doc);

					break;

				case "ft":
					doc = sXML.findtModel("%");
					tModelInfo[] tmi = dsXML.findtModel(doc);
					Console.WriteLine(doc.ToString());
					Console.ReadLine();
					break;

				case "sb":
					token = sXML.obterToken("xico","xico");
					businessEntity be = new businessEntity();
					name[] nomes = new name[1];
					nomes[0] = new name();
					nomes[0].Value = "Empresa XPTO teste";
					be.name = nomes;
					be.businessKey = "";
					doc = sXML.saveBusiness(token.authInfo,be);
					//Tratar a resposta
					be = dsXML.saveBusiness(doc);
					Console.WriteLine(doc);
					Console.ReadLine();
					break;

				case "bs":
					doc = sXML.saveService("db2admin","07A48720-2774-4940-BEAB-00F127970F68","841416","Credito","uuid:db77450d-9fa8-45d4-a7bc-04411d14e384");
					dsXML.saveService(doc);
					//dsXML.saveWebService();	
					break;

				case "ws":
					//Construcao da estrutura business service
					businessService bs = new businessService();
					//Construcao do bindingTemplate
					bindingTemplate[] bt = new bindingTemplate[1];
					bt[0] = new bindingTemplate();
					bt[0].bindingKey = "";
					bt[0].description = "O endereco para o envio da informacao";
					bt[0].accessPoint = new accessPoint();
					bt[0].accessPoint.URLType = URLType.mailto;
					bt[0].accessPoint.Value = "mailto:DCAmail@democredit.bar";
					//Construcao do tModelInstanceDetails
					tModelInstanceInfo[] tii = new tModelInstanceInfo[2];
					tii[0] = new tModelInstanceInfo();
					tii[0].tModelKey = "uuid:93335d49-3efb-48a0-acea-ea102b60ddc6";
					tii[0].description = "Utilizacao do protocolo HTTP";

					tii[1] = new tModelInstanceInfo();
					tii[1].tModelKey = "uuid:25ddf051-c164-11d5-85a6-801eef208714";
					tii[1].description = "Namespace onde os numero de credito sao utilizados";

					instanceDetails id = new instanceDetails();

					overviewDoc[] overdoc = new overviewDoc[1];
					overdoc[0] = new overviewDoc();
					overdoc[0].description = "Descricao de como utilizar este servico";
					overdoc[0].overviewURL = "http://localhost/DCAmail/howto";


					id.overviewDoc = new overviewDoc();
					id.overviewDoc = overdoc[0];

					tii[0].instanceDetails = id;
			
					bt[0].tModelInstanceDetails = tii;
			
					bs.bindingTemplates = bt;
					bs.serviceKey = "";
					bs.businessKey = "22446AC3-13EC-4274-A8AF-1948127D11C5";
					name[] nome = new name[1];
					nome[0] = new name();
					nome[0].Value = "Servico XPTO";
					bs.name = nome;
					//doc = sXML.saveService("db2admin",bs);
					doc = sXML.saveWebServiceSb("db2admin","2E4D9E09-36FE-4DB9-91B5-0AE71B03266C","Servico XPTO","Um servico porreiro","http","http://localhost/DCAmail/howto","Como utilizar o servico","","","","");

					break;

				case "ws_ss":
					doc = sXML.saveWebServiceSs("db2admin","1FEF6807-0A75-42E8-9030-28BB1E682299","Um servico","Uma descricao","http","http://www.qq.com","inscricao","","","","");
					Console.WriteLine(doc);
					Console.ReadLine();
					break;

				case "gbd":
					doc = sXML.getBusinessDetail("32530501-3793-4045-9713-215C136420B7");
					Console.WriteLine(doc);
					Console.ReadLine();
					dsXML.getBusinessDetail(doc);

					break;

				case "gtd":
					doc = sXML.gettModelDetail("UUID:251C26FE-147F-4C98-8AF5-3AA334281654");
					Console.WriteLine(doc);
					Console.ReadLine();
					dsXML.gettModelDetail(doc);

					break;

			}
		}
	}
}
