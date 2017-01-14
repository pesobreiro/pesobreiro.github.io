//nomesIp.cs
/*
	Vamos implementar uma classe que resolve nomes para ip's.
	Dns <servername> para determinar o ip do servidor
*/
using System;
using System.Net;

class nomesIp{
	static void Main(string[] args){
		if (args.Length == 0){
			Console.WriteLine("Ó meu ganda cam***, tens de introduzir pelo menos um argumento (URL) válido!!!");
			Console.WriteLine("USAGE:");
			Console.WriteLine("nomesIp <url> +<url>");
		}else{
			try{
				for(int x = 0; x < args.Length; x++){
					IPHostEntry hostInfo = Dns.GetHostByName(args[x]);
					IPAddress[] ips = hostInfo.AddressList;
					Console.WriteLine("--------------------");
					Console.WriteLine("Url: " + args[x]);
					Console.WriteLine("IP:  " + ips[0]);
				}
			}catch (Exception ex){
				Console.WriteLine("Excepção: " + ex);
			}
		}
	}
}