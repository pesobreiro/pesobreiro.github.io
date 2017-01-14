//Dns.cs
/*
        Vamos implementar uma classe que resolve nomes para IP´s.
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
		Console.WriteLine("Utilização: NomesIP  Lista_de_Nomes");		
	}
	else
	{
		try
		{
			for (int x = 0; x < args.Length; x++)
			{
		             IPHostEntry hostInfo = Dns.GetHostByName(args[x]);
	        	     IPAddress[] ips = hostInfo.AddressList;
			     Console.WriteLine("Nome do IP: "+args[x] + "  IP n.º: " + ips[0]);	
		             //Console.WriteLine(ips[0]);     
			}
		}
	
		catch (Exception ex)
		{
			Console.WriteLine("Execpção: " +ex);
		}
	}
     }
}