// created on 01-10-2002 at 22:07
using System;
using System.IO;
using System.Net;
using System.Text;

class Snarf {
       static void Main()      
       {
             //vamos obter os dados via http num url
             WebRequest pedidoWeb = WebRequest.Create("http://195.60.168.50/webdesign");
             WebResponse respostaWeb = pedidoWeb.GetResponse();
             
             //ler os dados do servidor
             Stream fluxo = respostaWeb.GetResponseStream();
             StreamReader leitorFluxo = new StreamReader(fluxo,Encoding.ASCII);
             
             
             //guardar em ficheiro
             string resultado = leitorFluxo.ReadToEnd();
             FileStream fs = new FileStream("resposta.txt",FileMode.OpenOrCreate);
             StreamWriter gravarFluxo = new StreamWriter(fs);
       	     
       	     gravarFluxo.Write(resultado);
       		 gravarFluxo.Flush();
       	
             //mostrar o resultado
             Console.WriteLine(resultado);
       	
       }
}
