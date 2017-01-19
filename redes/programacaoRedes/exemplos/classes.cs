class Dados
{
	int valorInterno;
	public void MostrarDado(int i)
	{
		valorInterno = i;
		System.Console.WriteLine(valorInterno);
	}
	
}

class Programa
{
	public static void Main()
	{
		//Instancia d1 da classe dados
		Dados d1 = new Dados();
				
		//Instancia d2 da classe dados
		Dados d2 = new Dados();

		d1.MostrarDado(1);
		d2.MostrarDado(2);
	}	
}