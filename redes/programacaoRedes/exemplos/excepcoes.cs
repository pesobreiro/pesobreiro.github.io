using System;

///<summary>
/// Isto e um exemplo de uma classe para trabalhar com excepcoes
///</summary>
class excepcoes
{
	///<summary>
	///	Ponto de entrada da aplicacao
	///</summary>	
	public static void Main()
	{
		try 
		{
			int i = 10;
			int j = 0;
			int resultado;
			
			resultado = i/j;
		}
		catch (Exception ex)
		{
			Console.WriteLine("Ocorreu uma excepcao:" + ex); 
		}
	}
}