class Media 
{
	static void Main() 
	{
		double[] array = {-10.7, 37.8, 101.1, 28, -4.9};

		double valor = media(array);

		System.Console.WriteLine("A média dos elementos do array é: " + valor);
	}

	static double media(double[] array) 
	{
		double valor = soma(array);
		double media = valor / array.Length;
		return media;
	}

	static double soma(double[] array) 
	{
		double soma = 0;

		for(int i = 0; i < array.Length; i++) 
		{
			soma += array[i];
		}

		return soma;
	}
}
