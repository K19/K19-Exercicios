class Tabuada 
{
	static void Main() 
	{
		int[][] tabuada = new int[10][];

		for (int i = 0; i < tabuada.Length; i++) 
		{
			tabuada[i] = new int[10];
			for (int j = 0; j < tabuada[i].Length; j++) 
			{
				tabuada[i][j] = (i + 1) * (j + 1);
			}
		}

		for (int i = 0; i < tabuada.Length; i++) 
		{
			for (int j = 0; j < tabuada[i].Length; j++) 
			{
				System.Console.WriteLine((i + 1) + " x " + (j + 1) + " = " + tabuada[i][j]);
			}
		}
	}
}
