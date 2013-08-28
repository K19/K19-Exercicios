class Arrays 
{
	static void Main() 
	{
		int[] array1 = new int[5];
		int[] array2 = new int[10];

		preencheArray(array1);
		preencheArray(array2);

		exibeArray(array1);
		exibeArray(array2);
	}

	static void preencheArray(int[] array) 
	{
		System.Random gerador = new System.Random();
		for(int i = 0; i < array.Length; i++) 
		{
			array[i] = (int)(gerador.NextDouble() * 100);
		}
	}

	static void exibeArray(int[] array) 
	{
		System.Console.WriteLine("Array: ");
		for(int i = 0; i < array.Length; i++) 
		{
			System.Console.WriteLine("array[" + i + "] = " + array[i]);
		}
		System.Console.WriteLine("------------------------------------");
	}
}
