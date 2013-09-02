class Inverte 
{
	static void Main() 
	{
		System.Console.WriteLine("Original");
		int[] array = {-10, 37, 101, 28, -4};
		exibeArray(array);

		System.Console.WriteLine("\nInvertendo...");
		inverte(array);
		exibeArray(array);
	}

	static void inverte(int[] array) 
	{
		int i = 0;
		int j = array.Length - 1;

		while(i < j) 
		{
			troca(array, i, j);
			i++;
			j--;
		}
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
