using System;

class excepcoes
{
	public static void Main()
	{
		try 
		{
			int i = 10;
			int resultado;
			
			resultado = i/0;
		}
		catch (Exception ex)
		{
			Console.WriteLine("Ocorreu uma excepcao:" + ex); 
		}
	}
}