// created on 01-10-2002 at 22:07
using System;
using System.IO;
using System.Net;
using System.Text;

class Snarf {
	static void Main(string[] args)
	{
		//Vamos obter os dados via HTTP num URL
		//WebRequest pedidoWeb = WebRequest.Create("http://"+args[0]);
		WebRequest pedidoWeb = WebRequest.Create("http://195.60.168.50/webdesign");
		WebResponse respostaWeb = pedidoWeb.GetResponse();
		
		//Ler os dados do servidor
		Stream fluxo = respostaWeb.GetResponseStream();
		StreamReader leitorFluxo = new StreamReader(fluxo,Encoding.ASCII);
		
		//Guardar num ficheiro
		string resultado = leitorFluxo.ReadToEnd();
		
		//FileStream fs = new FileStream(args[0]+".txt", FileMode.OpenOrCreate);
		FileStream fs = new FileStream("Resposta.txt", FileMode.OpenOrCreate);
		StreamWriter gravaFluxo = new StreamWriter(fs);
		
		gravaFluxo.Write(resultado);
		gravaFluxo.Flush();
		
		//Mostrar o resultado
		Console.WriteLine(resultado);
	}
}
