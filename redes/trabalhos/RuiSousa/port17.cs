// created on 02-10-2002 at 20:28
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class ServidorPorta17
{
	static string[] mensagens = {"Willcomen", "UDP port 17 server :D"};
	
	static void Main ()
	{
		//criar o ouvinte para a porta
		TcpListener tcpOuvinte = new TcpListener(17);
		tcpOuvinte.Start();
		
		Console.WriteLine("waiting for clients...");
		Console.WriteLine("press ctrl+c to kill me :~(");
		                  
		int numeroMensagens =1;
		
		while (true)
		{
			//aguardar por pedidos para a porta 17
			
			Socket s = tcpOuvinte.AcceptSocket();
			
			Char[] cArr = mensagens [1%2].ToCharArray();
			Byte[] bArr = Encoding.ASCII.GetBytes(cArr);
			
			//retornar os dados do cliente
			
			s.Send(bArr,bArr.Length,SocketFlags.None);
			//limpar o socket
			s.Shutdown(SocketShutdown.Both);
			s.Close();
			Console.WriteLine("message sent ...",numeroMensagens++ );
	
		    }
		}
	}
