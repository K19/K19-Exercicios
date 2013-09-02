class Embaralha 
{
	static void Main() 
	{
		System.Console.WriteLine("Original");
		int[] array = {-10, 37, 101, 28, -4};
		exibeArray(array);

		System.Console.WriteLine("\nEmbaralhando...");
		embaralha(array);
		exibeArray(array);

		System.Console.WriteLine("\nEmbaralhando...");
		embaralha(array);
		exibeArray(array);

		System.Console.WriteLine("\nEmbaralhando...");
		embaralha(array);
		exibeArray(array);
	}

	static void embaralha(int[] array) 
	{
		for(int i = 0; i < array.Length; i++) 
		{
			int j = aleatorio(i, array.Length - 1);
			troca(array, i, j);
		}
	}

	static int aleatorio(int i, int j) 
	{
		System.Random gerador = new System.Random();
		return (int)(gerador.NextDouble() * (j - i + 1)) + i;
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
