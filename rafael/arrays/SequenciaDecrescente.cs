class SequenciaDecrescente 
{
	static void Main() 
	{
		int[] array = new int[10];

		for (int i = 0; i < array.Length; i++) 
		{
			array[i] = array.Length - 1 - i;
		}

		for (int i = 0; i < array.Length; i++) 
		{
			System.Console.WriteLine(array[i]);
		}
	}
}
