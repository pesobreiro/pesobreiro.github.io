// Implementação de um cliente de Ficheiros
// O cliente "ouve" na porta 65000

using System;
using System.Net;
using System.IO;
using System.Net.Sockets;

class ClienteServidorFicheiros

{
	static void Main()
	{
		//Criar um cliente para comunicar com o Servidor
		TcpClient clienteServidor;
		NetworkStream fluxoServidor;
		StreamReader leitorFluxos;
		
		try
		{
			clienteServidor = new TcpClient ("localhost", 65000);
		
			//Criar um fluxo (Stream) de rede
		    fluxoServidor = clienteServidor.GetStream();
			//Utilizar um stream reader para obter a informacao do servidor
			leitorFluxos = new StreamReader(fluxoServidor);
			
			
			//Utilizar o fluxo para obter os dados do ficheiro
	
	string dados;
			
			//ler os dados do servidor mostra-los
			do
			{
				dados=leitorFluxos.ReadLine();
				if (dados != null)
				{
					Console.WriteLine(dados);					
				}
			}
			while (dados !=null);
			
			//Desligar a conexao ao Servidor
			fluxoServidor.Close();
			
				
		}
		catch (Exception ex)
		{
			Console.WriteLine ("Ocorreu um erro ao ler do servidor (0) 65000","localhost");
			Console.WriteLine ("Erro:",ex);
		}
		
	}	
	// Fechar conexao ao Servidor
}
