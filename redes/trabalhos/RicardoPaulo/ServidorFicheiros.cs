//Implementação de um servidor de ficheiros
//O servidor "ouve" na porta 5000
//0-1023		portas Wll Know
//1024 - 49151	portas registadas
//49152-655355	portas privadas
//Stocket = implementa uma ligação do tipo "connection oriented"
//com o cliente

using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class ServidorFicheiros
{
	static void Main ()
	{
		ServidorFicheiros servidor = new ServidorFicheiros();
		servidor.Arrancar();
	}
	
	private void Arrancar()
	{
		//Implementar um ouvinte tcp
		//para a porta 65000
		
		TcpListener ouvinte = new TcpListener (65000);
		ouvinte.Start();
		
		//Vamos ouvir até enviarmos o ficheiro
		while (true)
		{
			//Quando um cliente se ligar aceitamos a conexão
			Socket socketParaCliente = ouvinte.AcceptSocket();
			if (socketParaCliente.Connected)
			{
				Console.WriteLine("Ah, desgraçado, entraste no meu sistema");
				
				//Implementar o tratamento para o envio de ficheiro
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
						Console.WriteLine("Estamos a enviar..."+ textoFicheiro);
						gravadorFluxo.WriteLine(textoFicheiro);
						gravadorFluxo.Flush();
					}
				}
				while (textoFicheiro != null);
				
				leitorFluxo.Close();
				fluxoRede.Close();
				gravadorFluxo.Close();
				
				//Vamos terminar o envio
				
				Console.WriteLine("Desligar o chato do cliente");
				break;
				}
		}
	}
}
