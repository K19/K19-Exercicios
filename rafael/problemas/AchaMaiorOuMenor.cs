class AchaMaiorOuMenor 
{
	static void Main() 
	{
		double[] array = {-10.7, 37.8, 101.1, 28, -4.9};

		int posicaoDoMaior = maior(array);
		System.Console.WriteLine("O maior valor do array é: " + array[posicaoDoMaior]);
		System.Console.WriteLine("Esse valor está na posição: " + posicaoDoMaior);

		int posicaoDoMenor = menor(array);
		System.Console.WriteLine("O menor valor do array é: " + array[posicaoDoMenor]);
		System.Console.WriteLine("Esse valor está na posição: " + posicaoDoMenor);
	}

	static int maior(double[] array) 
	{
		int posicaoDoMaior = 0;

		for(int i = 1; i < array.Length; i++) 
		{
			if(array[posicaoDoMaior] < array[i]) 
			{
				posicaoDoMaior = i;
			}
		}

		return posicaoDoMaior;
	}

	static int menor(double[] array) 
	{
		int posicaoDoMenor = 0;

		for(int i = 1; i < array.Length; i++) 
		{
			if(array[posicaoDoMenor] > array[i]) 
			{
				posicaoDoMenor = i;
			}
		}

		return posicaoDoMenor;
	}
}
