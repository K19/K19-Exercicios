class JogoDaSomaImpar
{
	static void Main()
	{
		System.Random gerador = new System.Random();
		int soma = 0;
		int quantidadeDeSeis = 0;		

		for(int i = 0; i < 10; i++)
		{
			int numero = (int)(gerador.NextDouble() * 6 + 1);

			System.Console.WriteLine("Número: " + numero);

			if(numero == 1)
			{
				continue;
			}

			if(numero == 6)
			{
				quantidadeDeSeis++;
			}

			if(quantidadeDeSeis == 2)
			{
				System.Console.WriteLine("Dois seis! Você perdeu!");
				break;
			}

			soma += numero;
		}

		if(quantidadeDeSeis != 2)
{
			System.Console.WriteLine("Soma: " + soma);
			if(soma % 2 != 0)
			{
				System.Console.WriteLine("Soma ímpar! Você ganhou");
			} else
			{
				System.Console.WriteLine("Soma par! Você perdeu");
			}
		}
	}
}
