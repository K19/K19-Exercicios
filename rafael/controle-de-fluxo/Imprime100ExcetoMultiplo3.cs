class Imprime100ExcetoMultiplo3 
{
	static void Main() 
	{
		for (int i = 1; i <= 100; i++) 
		{
			if (i % 3 != 0) 
			{
				System.Console.WriteLine(i);
			}
		}
	}
}
