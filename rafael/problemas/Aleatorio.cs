class Aleatorio 
{
	static void Main() 
	{
		System.Console.WriteLine("Sorteando no intervalo [0, 10]");
		for(int i = 0; i < 10; i++) 
		{
			int numero = aleatorio(0, 10);
			System.Console.WriteLine(numero);
		}
		
		System.Console.WriteLine("\nSorteando no intervalo [-25, 10]");
		for(int i = 0; i < 10; i++) 
		{
			int numero = aleatorio(-25, 10);
			System.Console.WriteLine(numero);
		}
	}

	static int aleatorio(int i, int j) 
	{
		System.Random gerador = new System.Random();
		return (int)(gerador.NextDouble() * (j - i + 1)) + i;
	}
}
