// created on 02-10-2002 at 20:29
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class ServidorPorta17
{
	static string[] mensagens = {"Bem Vindo ao Servidor","Servidor Porta 17 protocolo UDP"};
	
	static void Main()
	{
		//Criar o ouvinte para a porta
		TcpListener tcpOuvinte = new TcpListener(17);
		tcpOuvinte.Start();
		
		Console.WriteLine("À espera que os clientes acedam ... ");
		Console.WriteLine("Pressione CTRL+C para terminar . ");
		
		int numeroMensagens = 1;
		
		while (true)
		{
			//Aguardar por pedidos para a porta 17
			
			Socket s = tcpOuvinte.AcceptSocket();
			
			//Implementar um Array de Bytes e outro de caracteres
			
			Char[] cArr = mensagens[numeroMensagens%2].ToCharArray();
			Byte[] bArr = Encoding.ASCII.GetBytes(cArr);
			
			
			//Retornar os dados ao cliente
			
			s.Send(bArr,bArr.Length,SocketFlags.None);
			
			//Limpar o Socket após envio
			
			s.Shutdown(SocketShutdown.Both);
			s.Close();
			Console.WriteLine("Mensagens Enviadas.." + numeroMensagens,numeroMensagens++ );
			Console.WriteLine("Protocolo :" + s.AddressFamily + " " + s.ProtocolType );
			       
		}
		
	}
}
