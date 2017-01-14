//Dns.cs
/*
	vamos implementar uma classe q resolve nomes para ips
	Dns <servername> para determinar o ip do servidor
*/

using System;
using System.Net;


class NomesIP
{
	static void Main(string[] args)
	{
                if (args[0] == "/?"


                try {
                for i = 0; i < args.length ; i++ )
                {
                IPHostEntry hostInfo = Dns.GetHostByName(args [0]);
                IPAddress[] ips = hostInfo.AddressList;
		Console.WriteLine(ips[0]);
		}
               }
                catch (Exception ex)
		{
		Console.WriteLine("bug:" + ex);
      		}
	}
}
