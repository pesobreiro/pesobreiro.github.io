// created on 01-10-2002 at 22:07
using System;
using System.IO;
using System.Net;
using System.Text;

class Snarf {
	static void Main()
	{
            
            //Vamos obter os dados via HTTP num URL
            WebRequest pedidoWeb =  WebRequest.Create("http://195.60.168.120");
            WebResponse respostaWeb = pedidoWeb.GetResponse();
            
            //Ler os Dados do Servidor
            Stream fluxo = respostaWeb.GetResponseStream();
            StreamReader leitorFluxo = new StreamReader(fluxo,Encoding.ASCII);
           
            
            //Guardar num Ficheiro
            string resultado = leitorFluxo.ReadToEnd();
             
            FileStream fs = new FileStream("Resposta.txt",FileMode.OpenOrCreate);
            StreamWriter gravaFluxo = new StreamWriter(fs);
            
            gravaFluxo.Write(resultado);
            
            //Mostrar o Resultado
            Console.WriteLine(resultado);
	}
}
