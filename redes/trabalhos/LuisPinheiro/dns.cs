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
		IPHostEntry hostInfo = Dns.GetHostByName ("www.str.isla.pt");
		IPAddress[] ips = hostInfo.AddressList;
		Console.WriteLine(ips[0]);
	}
}