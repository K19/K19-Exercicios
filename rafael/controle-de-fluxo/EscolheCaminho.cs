class EscolheCaminho 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();

		double valor = gerador.NextDouble();

		System.Console.WriteLine("VALOR: " + valor);

		if (valor < 0.5) 
		{
			System.Console.WriteLine("Vire à esquerda");

			valor = gerador.NextDouble();
	
			System.Console.WriteLine("VALOR: " + valor);
	
			if (valor < 0.5) 
			{
				System.Console.WriteLine("Vire à esquerda");
			} 
			else 
			{
				System.Console.WriteLine("Vire à direita");
			}
	
		} 
		else 
		{
			System.Console.WriteLine("Vire à direita");

			valor = gerador.NextDouble();

			System.Console.WriteLine("VALOR: " + valor);
	
			if (valor < 0.5) 
			{
				System.Console.WriteLine("Vire à esquerda");
			} 
			else 
			{
				System.Console.WriteLine("Vire à direita");
			}
		}
	}
}
