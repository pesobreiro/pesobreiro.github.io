//Dns.cs
/*
        Vamos implementar uma classe que resolve nomes para IPs.
        Dns <servername> para determinar o ip do servidor
*/

using System;
using System.Net;


class NomesIP
{
     static void Main(string[] args)
     {
	if (args.Length==0)
	{
		Console.WriteLine("Resolvedor de Nomes de IP.s");
		Console.WriteLine("Utilização: IPNomes  Lista_de_IPs");		
	}
	else
	{
		try
		{
			for (int x = 0; x < args.Length; x++)
			{
		             IPHostEntry ipInfo = Dns.GetHostByAddress(args[x]);
			     Console.WriteLine("IP: {0} Nome:{1}",args[0],ipInfo.HostName);	
			}
		}
	
		catch (Exception ex)
		{
			Console.WriteLine("Execpção: " +ex);
		}
	}
     }
}
