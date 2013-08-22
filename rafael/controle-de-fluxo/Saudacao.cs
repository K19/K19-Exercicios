class Saudacao 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();

		double hora = gerador.NextDouble() * 24;

		if (hora >= 0 && hora < 12) 
		{
			System.Console.WriteLine("Bom dia");
		} 
		else if (hora >= 12 && hora < 18) 
		{
			System.Console.WriteLine("Boa tarde");
		} 
		else if (hora >= 18 && hora < 24) 
		{
			System.Console.WriteLine("Boa noite");
		}
	}
}
