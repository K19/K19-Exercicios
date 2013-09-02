class Soma 
{
	static void Main() 
	{
		double[] array = {-10.7, 37.8, 101.1, 28, -4.9};
		
		double valor = soma(array);

		System.Console.WriteLine("A soma dos elementos do array é: " + valor);
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
