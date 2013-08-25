class SequenciaAleatoria 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();

		int[] array = new int[10];

		for (int i = 0; i < array.Length; i++) 
		{
			array[i] = (int)(gerador.NextDouble() * 100);
		}

		for (int i = 0; i < array.Length; i++) 
		{
			System.Console.WriteLine(array[i]);
		}
	}
}
