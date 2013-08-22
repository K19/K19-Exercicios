class ADivisivelPorB 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();

		int a = (int)(gerador.NextDouble() * 1000);
		int b = (int)(gerador.NextDouble() * 20);

		System.Console.WriteLine("a: " + a);
		System.Console.WriteLine("b: " + b);

		if (a % b == 0) 
		{
			System.Console.WriteLine("É divisível");
		} 
		else 
		{
			System.Console.WriteLine("Não é divisível");
		}
	}
}
