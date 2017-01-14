// created on 02-10-2002 at 21:49
//O servidor "ouve" na porta 65000
//0-1023		Portas Well-known
//1024-49151	Portas registadas
//49152-65535	Portas privadas
//socket = implementa uma ligação do tipo "connection oriented" com p cliente

using System;
using System.Net;
using System.Net.Sockets;
using System.IO;

class ServidorFicheiros{
	
	static void Main(){
		
		ServidorFicheiros servidor = new ServidorFicheiros();
		servidor.Arrancar();
		
	}
	
	private void Arrancar(){
		
		//Implementar um ouvinte tcp porta 65000
		TcpListener ouvinte = new TcpListener(65000);
		
		Console.WriteLine("A arrancar o serviço...");
		
		ouvinte.Start();
		
		Console.WriteLine("Serviço OK!");
		
		//Ouvir até enviar o ficheiro
		while(true){
			//Qd o cliente se ligar aceitamos a conexão
			Socket socketParaCliente = ouvinte.AcceptSocket();
			
			if (socketParaCliente.Connected){
				
				Console.WriteLine("Entraram...");
				
				//Implementrar o tratamento para o envio do ficheiro para o socket aberto
				NetworkStream fluxoRede = new NetworkStream(socketParaCliente);
				StreamWriter gravadorFluxo = new StreamWriter(fluxoRede);
				
				StreamReader leitorFluxo = new StreamReader("servidorPorta17.cs");
				
				string textoFicheiro;
				//Percorrer o ficheiro e envia-lo linha a linha para o cliente
				do{
					textoFicheiro = leitorFluxo.ReadLine();
					if (textoFicheiro != null){
						Console.WriteLine("Estamos a enviar..." + textoFicheiro);
						gravadorFluxo.WriteLine(textoFicheiro);
						gravadorFluxo.Flush();
					}				
				}while (textoFicheiro != null);				
				//fim do ciclo
				
				leitorFluxo.Close();
				fluxoRede.Close();
				gravadorFluxo.Close();
				
				//Vamos terminar o envio
				Console.WriteLine("Desligar o cliente");
				socketParaCliente.Close();				
			}
		}
	}	
}
