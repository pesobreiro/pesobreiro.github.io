//nomesIp.cs
/*
	Vamos implementar uma classe que resolve de ip's para url's
	Ip para determinar o nome do servidor
*/
using System;
using System.Net;

class nomesIp{
	static void Main(string[] args){
		if (args.Length == 0){
			Console.WriteLine(" meu ganda cam***, tens de introduzir pelo menos um argumento (URL) vlido!!!");
			Console.WriteLine("USAGE:");
			Console.WriteLine("nomesIp <url> +<url>");
		}else{
			try{
				for(int x = 0; x < args.Length; x++){
					IPHostEntry ipInfo = Dns.GetHostByAddress(args[x]);
					Console.WriteLine("--------------------");
					Console.WriteLine("IP:  " + args[0]);
					Console.WriteLine("Url: " + ipInfo.HostName);
				}
			}catch (Exception ex){
				Console.WriteLine("Excepo: " + ex);
			}
		}
	}
}
