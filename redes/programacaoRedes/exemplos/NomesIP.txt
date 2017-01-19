//NomesIP.cs
/*
 	Vamos implementar uma classe que resolve nomes para
	IP's.
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
			Console.WriteLine("Resolvedor de nomes");
			Console.WriteLine("Utilização: NomesIP lista_nomes");
		}
		else
		{
		  try{
	            Console.WriteLine("Resolvedor Nomes IPs devolveu");
		    for (int i = 0; i < args.Length ; i++)
		    {	
		       IPHostEntry hostInfo = Dns.GetHostByName(args[i]);
		       IPAddress[] ips = hostInfo.AddressList;	
		       Console.WriteLine("Nome:{0} ip:{1}", args[0], ips[0]);
                    }
		  }
		  catch (Exception ex)
		  {
		    Console.WriteLine("IP Nao encontrado, erro:" +ex);	
		  }
		}
	}

}