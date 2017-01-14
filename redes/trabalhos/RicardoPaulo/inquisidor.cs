//NomesIP.cs
/*
	Vamos imlementar uma classe que resolve nomes para IP's.
	NomesIP <servername> para determinar o ip do servidor
*/
using System;
using System.Net;

class NomesIP
{
	static void Main(string[] args)
	{
		if (args[0] == "/?")
		{
			Console.WriteLine("E o IP é:");
			Console.WriteLine("Utilização: NomesIP listanomes");
		}
		else
		{
			try{
			  Console.WriteLine("Resultado:");
			  for (int i = 0; i < args.Lenght ; i++)
			  {
				IPHostEntry hostInfo = Dns.GetHostByName(args[i]);
				IPAddress[] ips = hostInfo.AddressList;
				Console.WriteLine("Nome:{0} ip:{1}", args[0], ips[0]);
		    	  }
			}
			catch (Exception ex)
			{
		  	  Console.WriteLine("Banhada:" +ex);
			}	
		     }
		}
}
			