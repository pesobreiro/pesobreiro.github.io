using System;

///<summary>
///Isto � um exemplo de uma classe para trabalhar com excep��es
///</summary>
class excepcoes
{
	///<summary>
	///Ponto de entrada da aplica��o
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
			Console.WriteLine ("Ocorreu uma excep��o: " + ex);	
		}
        }
}