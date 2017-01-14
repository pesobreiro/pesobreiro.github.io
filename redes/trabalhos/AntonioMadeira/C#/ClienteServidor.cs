// created on 03-10-2002 at 20:34
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class ClienteServidorFicheiros
{
	static void Main()
	{
		//Criara um cliente para comunicar com o servidor
		TcpClient clienteServidor;
		NetworkStream fluxoServidor;
		StreamReader leitorFluxos;
		
		try
		{
			clienteServidor = new TcpClient("localhost",65000);
			//Criar um fluxo (stream) de rede
			fluxoServidor = clienteServidor.GetStream();
			//Utilizar um stream reader para obter a informação do servidor
			leitorFluxos = new StreamReader(fluxoServidor);
			//Utilizar o fluxo para obter os dados do ficheiro
			string dados;
			//Ler os dados do servidor
			do
			{
				dados = leitorFluxos.ReadLine();
				if (dados != null)
				{
					Console.WriteLine(dados);
				}
			}
			while (dados != null);
	
			//Desligar a conexão ao servidor
			fluxoServidor.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine("Não foi possível aceder ao servidor {0}:65000 !!!", "Localhost");
			Console.WriteLine("Erro: ", ex);
		}
	}
}
