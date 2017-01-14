//Dns.cs
/*
	Vamos implementar uma classe que resolve nomes para IP´s
	Dns <servername> para determinar o ip do servidor 

*/

using System;
using System.Net;

class NomesIP
{
	static void Main(string[] args)
	{
		try{

				
		for (int x = 0; x < args.Length; x++){
			IPHostEntry ipInfo = Dns.GetHostByAddress (args[x]);
			Console.WriteLine (x);		
			Console.WriteLine("ip:{0} Nome:{1}", args[0],ipInfo.HostName);
			
		}
		}
		catch (Exception ex)
		{
			Console.WriteLine("excepcao: " + ex);
		}	
}
}