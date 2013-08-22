class JogoDeDado2
{
	static void Main() 
	{
		int soma = 0;
		for(int i = 1; i <= 5; i++) 
		{
			System.Random gerador = new System.Random();

			System.Console.WriteLine("Lançamento: " + i);
			int numero = (int)(gerador.NextDouble() * 6 + 1);

			System.Console.WriteLine("Número: " + numero);

			if(numero % 2 == 0) 
			{
				System.Console.WriteLine("-----------------------");
				continue;
			}

			soma += numero;
		
			System.Console.WriteLine("Soma: " + soma);
			System.Console.WriteLine("-----------------------");

			if(soma > 9) 
			{
				System.Console.WriteLine("Você ganhou com " + i + " lançamentos");
				break;
			}
		}
	}
}
