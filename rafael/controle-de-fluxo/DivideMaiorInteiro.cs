class DivideMaiorInteiro 
{
	static void Main() 
	{
		int numero = 2147483647;

		while (numero >= 100) 
		{
			numero /= 2;
			System.Console.WriteLine(numero);
		}
	}
}
