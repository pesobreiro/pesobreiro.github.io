// created on 01-10-2002 at 22:07
using System;
using System.IO;
using System.Net;
using System.Text;

class pang {
	static void Main(){
		for (int x=0;x>=0;x++){
		WebRequest pedidoWeb = WebRequest.Create("http://195.60.168.50");
		WebResponse respostaWeb = pedidoWeb.GetResponse();
	
		//Ler os dados do servidor
		Stream fluxo = respostaWeb.GetResponseStream();
		StreamReader leitorFluxo = new StreamReader(fluxo,Encoding.ASCII);
		string resultado = leitorFluxo.ReadToEnd();
		Console.WriteLine(x);
		}
	}
}
