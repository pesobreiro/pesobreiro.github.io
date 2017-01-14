// created on 01-10-2002 at 22:04
using System;
using System.IO;
using System.Net;
using System.Text;

class Snarf
{
	static void Main(string[] args)
	
	{
	//Vamos obter os dados via http num url
	WebRequest pedidoWeb = WebRequest.Create("http://" + args);
	WebResponse respostaWeb = pedidoWeb.GetResponse();
	
	//Ler dados do Servidor
	Stream fluxo = respostaWeb.GetResponseStream();
	StreamReader leitorFluxo = new StreamReader(fluxo,Encoding.ASCII);
	

	
	//Guardar num ficheiro
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
