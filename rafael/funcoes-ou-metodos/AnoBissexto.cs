class AnoBissexto 
{
	static void Main() 
	{
		bool b = bissexto(2000);
		System.Console.WriteLine("2000 " + b);

		b = bissexto(2012);
		System.Console.WriteLine("2012 " + b);

		b = bissexto(2025);
		System.Console.WriteLine("2025 " + b);

		b = bissexto(2100);
		System.Console.WriteLine("2100 " + b);
	}

	static bool bissexto(int ano)
	{
		return ano % 400 == 0 || (ano % 100 != 0 && ano % 4 == 0);
	}
}
