// created on 01-10-2001 at 21:38
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
class clienteTCP
{
	static void Main()
	{
		TcpClient tcpClient = new TcpClient();
    	try
    	{
			tcpClient.Connect("localhost", 80);
			NetworkStream networkStream = tcpClient.GetStream();
	
			if(networkStream.CanWrite && networkStream.CanRead){
	
				// Does a simple write.
				Byte[] sendBytes = Encoding.ASCII.GetBytes("Is anybody there");
				networkStream.Write(sendBytes, 0, sendBytes.Length);
		
				// Reads the NetworkStream into a byte buffer.
				byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
				networkStream.Read(bytes, 0, (int) tcpClient.ReceiveBufferSize);
	
			   // Returns the data received from the host to the console.
			   string returndata = Encoding.ASCII.GetString(bytes);
			   Console.WriteLine("This is what the host returned to you: " + returndata);
	
			  }
			  else if (!networkStream.CanRead){
				  Console.WriteLine("You can not write data to this stream");
				  tcpClient.Close();
			  }
			  else if (!networkStream.CanWrite){             
				  Console.WriteLine("You can not read data from this stream");
				  tcpClient.Close();
			  }
			  Console.ReadLine();
       }
       catch (Exception e ) {
                  Console.WriteLine(e.ToString());
       }
	}
}
