// created on 01-10-2002 at 22:08
using System;
using System.IO;
using System.Net;
using System.Text;

class Snarf{
	static void Main(string[] args)
	{
		//vamos obter os dados via HTTP num URL
		WebRequest pedidoWeb =  WebRequest.Create ("http://195.60.168.120");
		WebResponse respostaWeb = pedidoWeb.GetResponse();
	
		//Ler os Dados do servidor
		Stream fluxo = respostaWeb.GetResponseStream();
		StreamReader leitorFluxo = new StreamReader(fluxo,Encoding.ASCII);
		//guardar num ficheiro
		string resultado = leitorFluxo.ReadToEnd();
		
		FileStream fs = new FileStream("resposta.txt", FileMode.OpenOrCreate);
		StreamWriter gravaFluxo = new StreamWriter(fs);
		
		gravaFluxo.Write(resultado);
		
		//mostrar o resultado
		Console.WriteLine(resultado);
	}
}
