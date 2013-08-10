class TestaOperadorTernario 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();
		int a = (int)(gerador.NextDouble() * 100);
		int b = (int)(gerador.NextDouble() * 100);
		
		System.Console.WriteLine(a < b ? "a < b" : "a >= b");
	}
}
