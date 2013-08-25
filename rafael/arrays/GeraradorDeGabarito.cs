class GeraradorDeGabarito 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();
		int[] gabarito = new int[10];
		for(int i = 0; i < gabarito.Length; i++) 
		{
			gabarito[i] = (int)(gerador.NextDouble() * 3 + 1);
			System.Console.Write(gabarito[i] + " ");
		}
		System.Console.WriteLine("gabarito");
	}
}
