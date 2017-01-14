// created on 02-10-2002 at 21:52
// O servidor "ouve" na porta 65000
// 0-1023 portas well-known
// 1024-49151 portas registadas
// 49152-65535 portas privadas
// socket = implementa uma ligação do tipo "connection oriented"
// com o cliente

using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class ServidorFicheiros

{
	static void Main()
	{
		ServidorFicheiros servidor = new ServidorFicheiros();
		// Falta arrancar o metodo inicial
		servidor.Arrancar();
		
	}
	
	private void Arrancar()
	{
		// implementar um ouvinte tcp
		// para a porta 65000
		
		
		TcpListener ouvinte = new TcpListener(65000);
		ouvinte.Start();
		
		Console.WriteLine("A escuta ...");
		
		//Vamos ouvir um cliente se ligar aceitamos a conexão
		Socket socketParaCliente = ouvinte.AcceptSocket();
		if (socketParaCliente.Connected)
		{
			Console.WriteLine("Entraram...");
			
			// Implementar o tratamento para o envio do ficheiro
			
			NetworkStream fluxoRede = new NetworkStream(socketParaCliente);
			
			StreamWriter gravadorFluxo = new StreamWriter(fluxoRede);
			
			StreamReader leitorFluxo = new StreamReader("servidorPorta17.cs");
			
			String textoFicheiro;
			// Percorrer o ficheiro e envia-lo linha a linha para o cliente
			do
			{
				textoFicheiro = leitorFluxo.ReadLine();
				if (textoFicheiro != null)
				{
					Console.WriteLine("Estamos a enviar..." + textoFicheiro);
					gravadorFluxo.WriteLine(textoFicheiro);
					gravadorFluxo.Flush();
				}
			}
			while (textoFicheiro != null);
	
		
			leitorFluxo.Close();
			fluxoRede.Close();
			gravadorFluxo.Close();
			
		// Vamos terminar o envio
		
		Console.WriteLine("Desligar o cliente");
		socketParaCliente.Close();
		//break;
		}
	}
}
