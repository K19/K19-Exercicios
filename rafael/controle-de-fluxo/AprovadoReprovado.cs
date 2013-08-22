class AprovadoReprovado 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();

		double nota = gerador.NextDouble() * 10;

		System.Console.WriteLine("A nota do aluno é: " + nota);

		if (nota < 6) 
		{
			System.Console.WriteLine("REPROVADO");
		} 
		else 
		{
			System.Console.WriteLine("APROVADO");
		}
	}
}
