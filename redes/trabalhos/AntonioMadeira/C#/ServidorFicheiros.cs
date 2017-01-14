// created on 02-10-2002 at 21:44
//Implementação de um servidor de ficheiros
//O servidor ouve na porta 6500
//    0- 1023  portas Well Know
// 1024-49151  Portas registadas
//49152-65535  portas privadas
//Socket = implementa uma ligação "connection oriented"
//com o cliente

using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class ServidorFicheiros
{
	static void Main()
	{
		ServidorFicheiros servidor = new ServidorFicheiros();
		servidor.Arrancar();
	}
	private void Arrancar()
	{
		//Implementar um ouvinte TCP para a porta 65000
		TcpListener ouvinte = new TcpListener(65000);
		ouvinte.Start();
		
		//Vamos ouvir até enviarmos o ficheiro
		while (true)
		{
			//Quando o cliente se ligar aceitamos a conexão
			Socket socketParaCliente = ouvinte.AcceptSocket();
			if (socketParaCliente.Connected)
			{
				Console.WriteLine("Entraram !!!");
				//Implementar o tratamento para o envio do ficheiro
				NetworkStream fluxoRede = new NetworkStream(socketParaCliente);
				StreamWriter gravadorFluxo = new StreamWriter(fluxoRede);				
				StreamReader leitorFluxo = new StreamReader("ServidorPorta17.cs");
				string textoFicheiro;
				//Percorrer o ficheiro e enviá-lo linha à linha para o cliente
				do
				{
					textoFicheiro = leitorFluxo.ReadLine();
					if (textoFicheiro != null)
					{
						Console.WriteLine("Estamos a enviar !!!" + textoFicheiro);
						gravadorFluxo.WriteLine(textoFicheiro);
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
				//break;
			}
		}
	}
}
