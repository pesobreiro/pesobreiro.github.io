// Implementação dum Cliente de Ficheiros
// O Cliente "ouve" para a porta 65000

using System;
using System .IO;
using System.Net;
using System.Net.Sockets;

class ClienteServidorFicheiros
{
	
	static void Main()
	{
		
	
	//Criar um cliente para comunicar com o servidor
		TcpClient clienteServidor;
		NetworkStream fluxoServidor;
		StreamReader leitorFluxos;
		try
		{
		
			clienteServidor = new TcpClient ( "localhost",65000);
			//Criar um fluxo (Stream) de rede
			fluxoServidor =clienteServidor.GetStream ();
			//Utilizar um stream reader para obter a informação do servidor
	    	leitorFluxos =new StreamReader(fluxoServidor);
		
			//Utilizar um fluxo para obter os dados do ficheiro
		
			string dados;
			
			//ler os dados do servidor e mostrá-los
			do
			{
				dados = leitorFluxos.ReadLine();
			    if ( dados !=null)
			    {
			    	Console.WriteLine(dados); 
			    }
			
			}
			while (dados !=null);
				
			//Desligar a conexão ao servidor
					
			fluxoServidor.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine ("Ocorreu um erro a ler do servidor...");
			Console.WriteLine ("Erro:",ex);
		}
	}
}
