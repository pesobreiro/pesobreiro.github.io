// created on 02-10-2002 at 20:29
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class servidorPorta17{

	static string[] mensagens = {"Bem Vindo ao Servidor","Servidor Porta 17 Protocolo UDP"};

	static void Main(){
		//Criar o ouvinte para a porta 17		
		TcpListener tcpOuvinte = new TcpListener(17);
		tcpOuvinte.Start();
		
		Console.WriteLine("Á espera que os clientes acedam.");
		Console.WriteLine("Pressione CTRL + C para terminar ...");
		
		int numeroMensagens = 1;
		//o true torna o ciclo infinito - quebra com o [ctrl + c]
		while(true){
			
			//Aguardar por pedidos para a porta 17
			Socket s = tcpOuvinte.AcceptSocket();
			
			Char[] cArr = mensagens[numeroMensagens%2].ToCharArray();
			Byte[] bArr = Encoding.ASCII.GetBytes(cArr);
			
			//Retornar resultados para o cliente
			s.Send(bArr,bArr.Length,SocketFlags.None);
			//Limpar o socket
			s.Shutdown(SocketShutdown.Both);
			s.Close();
			Console.WriteLine("Mensagens enviadas ... {0}", numeroMensagens, numeroMensagens++);
			Console.WriteLine("Protocolo: " + s.AddressFamily + " " + s.ProtocolType);
		}
	}
}
