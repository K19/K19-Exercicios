class TestaNumeroAleatorio 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();
		
		double numeroAleatorio = gerador.NextDouble() * 100;
		
		System.Console.WriteLine(numeroAleatorio);
	}
}
