// created on 02-10-2002 at 21:53
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class servidorFicheiros
{
	static void Main()
	
	{

	servidorFicheiros servidor = new servidorFicheiros();
	//Falta arrancar o metodo inicial
	//........
	servidor.Arrancar();	
	}
	
	private void Arrancar()
	
	{
		//Implementar um ouvinte TCP
		//para a porta 65000
		
		TcpListener ouvinte = new TcpListener(65000);
		ouvinte.Start();
		
		//Vamos ouvir até enviarmos o ficheiro
		
		while(true)
		{
			//Quando um cliente se ligar, aceitamos a conexao
			
			Socket socketParaCliente = ouvinte.AcceptSocket();
			
			//Verificar se o cliente se ligou
			
			if (socketParaCliente.Connected)
			{
				Console.WriteLine("Entraram.");
				
				//Implementar o tratamento para o envio dos ficheiros
				
				NetworkStream fluxoRede = new NetworkStream(socketParaCliente);
				StreamWriter gravadorFluxo = new StreamWriter(fluxoRede);
				
				StreamReader leitorFluxo = new StreamReader("ServidorPorta17.cs");
				
				string textoFicheiro;
				
				//Percorrer o ficheiro e enviá-lo linha a linha para o cliente
				do 
				{
					textoFicheiro = leitorFluxo.ReadLine();
					if (textoFicheiro != null)
					{
						Console.WriteLine("A enviar ... " + textoFicheiro);
						gravadorFluxo.WriteLine(textoFicheiro);
						//Assegurar que depois de enviar a linha, vamos limpar o buffer de leitura de linhas
						gravadorFluxo.Flush();
						
					}
				}
				
				while (textoFicheiro != null);
				
				leitorFluxo.Close();
				fluxoRede.Close();
				gravadorFluxo.Close();
				
				//Vamos terminar o envio
				
				Console.WriteLine("Desligar o cliente");
				
				socketParaCliente.Close();
				break;
				             
			}			
		}
	}
}
