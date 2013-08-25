class TabelaQualquer 
{
	static void Main() 
	{
		int[][] array = new int[3][];

		for (int i = 0; i < array.Length; i++) 
		{
			array[i] = new int[3];
		}

		array[0][0] = 19;
		array[0][1] = 22;
		array[0][2] = 31;
		array[1][0] = 2;
		array[1][1] = 51;
		array[1][2] = 12;
		array[2][0] = 41;
		array[2][1] = 11;
		array[2][2] = 3;


		for (int i = 0; i < array.Length; i++) 
		{
			for (int j = 0; j < array[i].Length; j++) 
			{
				System.Console.WriteLine(array[i][j]);
			}
		}
	}
}
