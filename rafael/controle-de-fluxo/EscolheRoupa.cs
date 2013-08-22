class EscolheRoupa 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();
	
		double valor = gerador.NextDouble();

		if (valor < 0.5) 
		{
			System.Console.WriteLine("camiseta preta");
		} 
		else 
		{
			System.Console.WriteLine("camiseta vermelha");
		}

		valor = gerador.NextDouble();

		if (valor < 0.5) 
		{
			System.Console.WriteLine("calça jeans");
		} 
		else 
		{
			System.Console.WriteLine("bermuda");
		}

		valor = gerador.NextDouble();

		if (valor < 0.5) 
		{
			System.Console.WriteLine("tênis");
		} 
		else 
		{
			System.Console.WriteLine("sapato");
		}

		valor = gerador.NextDouble();

		if (valor < 0.5) 
		{
			System.Console.WriteLine("boné");
		} 
		else 
		{
			System.Console.WriteLine("óculos");
		}
	}
}
