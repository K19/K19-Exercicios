class SequenciaCrescente 
{
	static void Main() 
	{
		int[] array = new int[10];

		for (int i = 0; i < array.Length; i++) 
		{
			array[i] = i;
		}

		for (int i = 0; i < array.Length; i++) 
		{
			System.Console.WriteLine(array[i]);
		}
	}
}
