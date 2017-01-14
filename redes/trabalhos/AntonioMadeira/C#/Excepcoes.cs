using System;

///<summary>
///Isto é um exemplo de uma classe para trabalhar com excepções
///</summary>
class excepcoes
{
	///<summary>
	///Ponto de entrada da aplicação
	///</summary>

	public static void Main()
	{
		
		try
		{
			int i = 10;
			int j = 0;
			int resultado = i/j;
		}
		catch (Exception ex)
		{
			Console.WriteLine ("Ocorreu uma excepção: " + ex);	
		}
        }
}