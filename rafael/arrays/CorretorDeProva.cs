class CorretorDeProva 
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

		int[][] respostas = new int[5][];

		for(int i = 0; i < respostas.Length; i++) 
		{
			respostas[i] = new int[10];
			for(int j = 0; j < respostas[i].Length; j++) 
			{
				respostas[i][j] = (int)(gerador.NextDouble() * 3 + 1);
				System.Console.Write(respostas[i][j] + " ");
			}
			System.Console.WriteLine("aluno " + (i + 1));
		}
		
		System.Console.WriteLine("Resultado:");
		for(int i = 0; i < respostas.Length; i++) 
		{
			int acertos = 0;
			for(int j = 0; j < respostas[i].Length; j++) 
			{
				if(gabarito[j] == respostas[i][j]) 
				{
					acertos++;
				}
			}
			System.Console.WriteLine("Aluno " + (i + 1) + ": " + acertos);
		}
	}
}
