class UseTernarioNegacaoIncrementoDecremento 
{
	static void Main() 
	{	
		int a = 10;
		int b = 8;

		System.Console.WriteLine((a < b) ? a : b);
		System.Console.WriteLine(!(a < b) ? "Marcelo" : "Jonas");
		System.Console.WriteLine((a < b) ? a : ++b);
		System.Console.WriteLine(!(--a == b) ? a : b + 1);
	}
}
