// created on 02-10-2002 at 21:53
using System;
using System.Net;
using System.IO;
using System.Net.Sockets;

class servidorFicheiros
{
	
	static void Main()
	{
		servidorFicheiros servidor = new servidorFicheiros();
		//falta arrancar o metodo inicial
		servidor.Arrancar();
	}
	
	
	public void Arrancar()
	{
		
		//implementer um ouvinte tcp
		//para a porta 65000
		
		TcpListener ouvinte = new TcpListener(65000);
		ouvinte.Start();
		
		while (true)
		{
			//quando um cliente ligar aceitamos a conexao
			
			Socket socketParaCliente = ouvinte.AcceptSocket();
			
			//verificar se o cliente se ligou
			
			if (socketParaCliente.Connected)
			{
				Console.WriteLine("entraram");
				
				//implementar o tratamento para o envio dos ficheiros
				
				NetworkStream fluxoRede = new NetworkStream(socketParaCliente);
				
				StreamWriter gravadorFluxo = new StreamWriter (fluxoRede);
				StreamReader leitorFluxo = new StreamReader ("port17.cs");
				
				string textoFicheiro;
				
				//percorrer o ficheiro e envia-lo linha a linha para o cliente
				do
				{
					textoFicheiro = leitorFluxo.ReadLine();
					if (textoFicheiro != null)
					{
						Console.WriteLine("a enviar..." + textoFicheiro);
						gravadorFluxo.WriteLine(textoFicheiro);
						gravadorFluxo.Flush();
					}
				}
				while (textoFicheiro != null);
				
				leitorFluxo.Close();
				fluxoRede.Close();
				gravadorFluxo.Close();
				
				//terminar envio
				
				Console.WriteLine("desligar o cliente");
			}  
		}
	}
}
