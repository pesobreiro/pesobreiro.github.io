using System;

namespace SiST.UddiAPI.UddiData
{
	/// <summary>
	/// Enumeração dos diversos tipos de URLs que são possíveis utilizar
	/// no accessPoint
	/// </summary>
	public enum URLType 
	{
		/// <summary>
		/// indica que o accessPoint está formatado como um endereço que correio electrónico 
		/// ex. mailto: user@subdominio.dominio
		/// </summary>
		mailto,
		/// <summary>
		/// http: o accessPoint contêm o URL com o endereço HTTP 
		/// ex. http://subdominio.dominio/local
		/// </summary>
		http,
		/// <summary>
		/// http: o accessPoint contêm o URL com o endereço HTTPS
		/// ex. https://subdominio.dominio/local
		/// </summary>
		https,
		/// <summary>
		/// ftp: o accessPoint contêm o endereço FTP 
		/// ex. ftp://subdominio.dominio/local
		/// </summary>
		ftp,
		/// <summary>
		/// fax: o accessPoint contêm um número de telefone de uma máquina de fax 
		/// ex. 123 123 123123123
		/// </summary>
		fax,
		/// <summary>
		/// phone: o accessPoint contêm um número de telefone ligado a uma pessoa ou 
		/// um equipamento de resposta automática (ex. 123 123 123123123).
		/// </summary>
		phone,
		/// <summary>
		/// other: outro tipo de endereço
		/// </summary>
		other,
	}
}
