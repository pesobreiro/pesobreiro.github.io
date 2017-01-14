//Dns.cs
/*
	Vamos implementar uma classe que resolve nomes para IP's
	Dns <servername> para determinar o ip do servidor
*/

using System;
using System.Net;


Class NOmesIP
{
	static Void Main(string[] args)
	{
		IPHostEntry hostInfo = Dns.GetHostByName("www.str.isla.pt");
		Console.WriteLine(hostInfo[0]);
	}
}