// created on 01-10-2001 at 22:00
using System;
using System.IO;
using System.Net;
using System.Text;

class Snarf {
	static void Main(string[] args)
	{
		//Vamos obter os dados via HTTP num URL
		WebRequest pedidoWeb = WebRequest.Create("http://" + args[0]);
		WebResponse respostaWeb = pedidoWeb.GetResponse();
		
		//Ler os dados do servidor
		Stream fluxo = respostaWeb.GetResponseStream();
		StreamReader leitorFluxo = new StreamReader(fluxo,Encoding.ASCII);
		
		//Guardar num ficheiro
		
		//Nao grava > 1024 bytes ????
		fluxo.Length
		leitorFluxo.ReadLine()
		string resultado = leitorFluxo.ReadToEnd();

		FileStream fs = new FileStream(args[0] + ".txt",FileMode.OpenOrCreate);
		StreamWriter gravaFluxo = new StreamWriter(fs);
		
		gravaFluxo.Write(resultado);
		
		
		//Mostrar o Resultado
		Console.WriteLine(resultado);
	}
}

