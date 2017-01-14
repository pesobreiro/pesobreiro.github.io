//Dns.cs
/*
        Vamos implementar uma classe que resolve nomes para IPs.
        Dns <servername> para determinar o ip do servidor
*/

using System;
using System.Net;


class Dns
{
     static void Main(string[] args)
     {
             IPHostEntry hostInfo = Dns.GetHostByName("www.clix.pt.pt");
             Console.WriteLine(hostInfo[0]);     
     }
}
