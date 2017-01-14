// created on 01-10-2002 at 22:11
using System;
using System.IO;
using System.Net;
using System.Text;

class Snarf {
	static void Main()
	{
	//Vamos obter o dados via HTTP num URL
	WebRequest pedidoWeb = WebRequest.Create("http://195.60.168.50/webDesign");
	WebResponse respostaWeb = pedidoWeb.GetResponse();
	
	//Ler os dados do servidor
	Stream fluxo = respostaWeb.GetResponseStream();
	StreamReader leitorFluxo = new StreamReader(fluxo,Encoding.ASCII);
	
	//Guardar num ficheiro
	string resultado = leitorFluxo.ReadToEnd();
	
	FileStream fs = new FileStream("resposta.txt",FileMode.OpenOrCreate);
	StreamWriter gravaFluxo = new StreamWriter (fs);
	
	gravaFluxo.Write(resultado);
	gravaFluxo.Flush();
	
	//Mostrar o Reultado
	Console.WriteLine(resultado);
	}
}
