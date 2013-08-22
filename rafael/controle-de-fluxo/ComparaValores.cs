class ComparaValores
{
	static void Main()
	{
		System.Random gerador = new System.Random();

		double primeiro = gerador.NextDouble();
		double segundo = gerador.NextDouble();
	
		System.Console.WriteLine("Primeiro: " + primeiro);
		System.Console.WriteLine("Segundo: " + segundo);

		if(primeiro > segundo)
		{
			System.Console.WriteLine("Primeiro > Segundo");
		} 
		else if(primeiro < segundo)
		{
			System.Console.WriteLine("Segundo > Primeiro");
		} 
		else
		{
			System.Console.WriteLine("Primeiro = Segundo");
		}
	}
}
