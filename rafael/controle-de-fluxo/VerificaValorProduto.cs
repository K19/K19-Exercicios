class VerificaValorProduto 
{
	static void Main() 
	{
		System.Random gerador = new System.Random();

		double precoDoProduto1 = gerador.NextDouble() * 1000;
		double precoDoProduto2 = gerador.NextDouble() * 1000;

		System.Console.WriteLine("O preço do produto 1 é: " + precoDoProduto1);
		System.Console.WriteLine("O preço do produto 2 é: " + precoDoProduto2);

		if (precoDoProduto1 < precoDoProduto2) 
		{
			System.Console.WriteLine("O produto 1 é o mais barato");
		} 
		else 
		{
			if(precoDoProduto2 < precoDoProduto1)
			{
				System.Console.WriteLine("O produto 2 é o mais barato");
			} 
			else 
			{
				System.Console.WriteLine("Os preços dos dois produtos são iguais");
			}
		}
	}
}
