class Troca 
{
	static void Main() 
	{
		System.Console.WriteLine("Original");
		int[] array = {-10, 37, 101, 28, -4};
		exibeArray(array);

		System.Console.WriteLine("\nTroca 0 e 2");
		troca(array, 0, 2);
		exibeArray(array);

		System.Console.WriteLine("\nTroca 1 e 3");
		troca(array, 1, 3);
		exibeArray(array);
	}

	static void troca(int[] array, int i, int j) 
	{
		int auxiliar = array[i];
		array[i] = array[j];
		array[j] = auxiliar;
	}

	static void exibeArray(int[] array) 
	{
		System.Console.Write("{");

		for(int i = 0; i < array.Length - 1; i++) 
		{
			System.Console.Write(array[i] + ", ");
		}
	
		System.Console.WriteLine(array[array.Length - 1] + "}");
	}
}
