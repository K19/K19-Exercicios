class GeraApostaMegaSena 
{
	static void Main() 
	{
		for(int i = 0; i < 10; i++) 
		{
			int[] array = geraApostaMegaSena();
			System.Console.Write("Aposta " + (i + 1) + ": ");
			exibeArray(array);
		}
	}

	static int[] geraApostaMegaSena() 
	{
		int[] numeros = new int[60];
		for(int i = 0; i < numeros.Length; i++) 
		{
			numeros[i] = i + 1;
		}

		int[] aposta = new int[6];
		for(int i = 0; i < aposta.Length; i++) 
		{
			int j = aleatorio(i, numeros.Length - 1);
			aposta[i] = numeros[j];
			troca(numeros, i, j);
		}

		return aposta;
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
