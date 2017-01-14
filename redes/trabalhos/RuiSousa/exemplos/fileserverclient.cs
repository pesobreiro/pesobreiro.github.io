// created on 03-10-2002 at 20:38
//o cliente ouve na porta 65000

using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class ClienteServidorFicheiros
{
	static void Main()
	{
		//criar um cliente para comunicar com o servidor
		TcpClient clienteServidor;
		
		try
		{
			clienteServidor = new TcpClient("localhost",65000);

			//criar um fluxo (stream) de rede
			NetworkStream fluxoServidor = clienteServidor.GetStream();
			//utilizar um stream reader para obter a informaçao de servidor
			StreamReader leitorFluxos = new StreamReader(fluxoServidor);
			
			//utilizar o fluxo para obter os dados do ficheiro
			
		
			string dados;
			
			//ler os dados do servidor e mostra los
			
			do
			{
				dados = leitorFluxos.ReadLine();
				if (dados !=null)
				{
					Console.WriteLine(dados);
				
			
				}
			}
			while(dados != null);
			//desligar ligacao ao servidor
			clienteServidor.Close();
		}
		catch (Exception ex)
		{
		
			Console.WriteLine("nao foi possivel aceder ao server {0}:65000","localhost");
			Console.WriteLine("erro",ex);
		}
		
	}
}
