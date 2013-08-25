class SequenciaImpar 
{
	static void Main() 
	{
		int[] array = new int[10];

		for (int i = 0; i < array.Length; i++) 
		{
			array[i] = 2 * i + 1;
		}

		for (int i = 0; i < array.Length; i++) 
		{
			System.Console.WriteLine(array[i]);
		}
	}
}
