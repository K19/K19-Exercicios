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

		int pares1 = contaPar(array1);
		int pares2 = contaPar(array2);

		System.Console.WriteLine("Quantidade de pares do primeiro array: " + pares1);
		System.Console.WriteLine("Quantidade de pares do segundo array: " + pares2);
	}

	static int contaPar(int[] array) 
	{
		int pares = 0;
		for(int i = 0; i < array.Length; i++) 
		{
			if(array[i] % 2 == 0) 
			{
				pares++;
			}
		}
		return pares;
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
