class CartoesDeEstacionamento
{
	static void Main()
	{
		for(int i = 1; i <= 3; i++)
		{
			for(int j = 1; j <= 9; j++)
			{
				for(int k = 1; k <= 4; k++)
				{
					System.Console.WriteLine("BLOCO: " + i + " APTO: " + (j * 10 + k)); 
				}
			}
		}
	}
}
