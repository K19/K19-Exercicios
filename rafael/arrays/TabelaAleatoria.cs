class TabelaAleatoria 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();
		
		int[][] array = new int[3][];

		for (int i = 0; i < array.Length; i++) 
		{
			array[i] = new int[3];
			for (int j = 0; j < array[i].Length; j++) 
			{
				array[i][j] = (int)(gerador.NextDouble() * 100);
			}
		}

		for (int i = 0; i < array.Length; i++) 
		{
			for (int j = 0; j < array[i].Length; j++) 
			{
				System.Console.WriteLine(array[i][j]);
			}
		}
	}
}
