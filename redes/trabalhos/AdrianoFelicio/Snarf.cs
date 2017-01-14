// created on 01-10-2002 at 22:07
using System;
using System.IO;
using System.Net;
using System.Text;

class Snarf {
	static void Main(string[] args){
		//Vamos obter os dados via HTTP num URL
		WebRequest pedidoWeb = WebRequest.Create("http://" + args[0]);
		WebResponse respostaWeb = pedidoWeb.GetResponse();
	
		//Ler os dados do servidor
		Stream fluxo = respostaWeb.GetResponseStream();
		StreamReader leitorFluxo = new StreamReader(fluxo,Encoding.ASCII);
		string resultado = leitorFluxo.ReadToEnd();
		
		//Mostrar o resultado
		Console.WriteLine(resultado);

		//Guardar num ficheiro
		FileStream fs = new FileStream(args[0] + ".htm",FileMode.OpenOrCreate);
		StreamWriter gravaFluxo = new StreamWriter(fs);
		gravaFluxo.Write(resultado);
	}
}
