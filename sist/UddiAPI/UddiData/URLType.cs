using System;

namespace SiST.UddiAPI.UddiData
{
	/// <summary>
	/// Enumera��o dos diversos tipos de URLs que s�o poss�veis utilizar
	/// no accessPoint
	/// </summary>
	public enum URLType 
	{
		/// <summary>
		/// indica que o accessPoint est� formatado como um endere�o que correio electr�nico 
		/// ex. mailto: user@subdominio.dominio
		/// </summary>
		mailto,
		/// <summary>
		/// http: o accessPoint cont�m o URL com o endere�o HTTP 
		/// ex. http://subdominio.dominio/local
		/// </summary>
		http,
		/// <summary>
		/// http: o accessPoint cont�m o URL com o endere�o HTTPS
		/// ex. https://subdominio.dominio/local
		/// </summary>
		https,
		/// <summary>
		/// ftp: o accessPoint cont�m o endere�o FTP 
		/// ex. ftp://subdominio.dominio/local
		/// </summary>
		ftp,
		/// <summary>
		/// fax: o accessPoint cont�m um n�mero de telefone de uma m�quina de fax 
		/// ex. 123 123 123123123
		/// </summary>
		fax,
		/// <summary>
		/// phone: o accessPoint cont�m um n�mero de telefone ligado a uma pessoa ou 
		/// um equipamento de resposta autom�tica (ex. 123 123 123123123).
		/// </summary>
		phone,
		/// <summary>
		/// other: outro tipo de endere�o
		/// </summary>
		other,
	}
}
