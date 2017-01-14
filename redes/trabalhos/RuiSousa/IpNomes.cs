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
			Console.WriteLine("Resolvedor de IPs");
			Console.WriteLine("Utilizao: IPNomes lista_IPs");
		}
		else
		{
		  try{
	            Console.WriteLine("Resolvedor Nomes IPs devolveu");
		    for (int i = 0; i < args.Length ; i++)
		    {	
		       IPHostEntry ipInfo = Dns.GetHostByAddress(args[i]);
		       Console.WriteLine("IP:{0} Nome:{1}", args[0], ipInfo.HostName);
                    }
		  }
		  catch (Exception ex)
		  {
		    Console.WriteLine("Nome nao encontrado, erro:" +ex);	
		  }
		}
	}

}
