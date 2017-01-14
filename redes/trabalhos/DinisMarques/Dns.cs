//Dns.cs
/*
	Vamos implementar uma classe que resolve nomes para IP's
	Dns <servername> para determinar o ip do servidor
*/

using System;
using System.Net;

class Dns
{
	static void Main(string[] args)
	{
		IPHostEntry hostInfo = Dns.GetHostByNamne("www.str.isla.pt");
		Console.WriteLine(hostInfo[0]);	
	}
}
