class GeraradorDeRespostasAleatorias 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();
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
	}
}
