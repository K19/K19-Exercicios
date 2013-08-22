class ContaUns
{
	static void Main()
	{
		System.Random gerador = new System.Random();

		double numero = gerador.NextDouble();
		System.Console.WriteLine(numero);

		string s = "" + numero;
		int resposta = 0;		

		for(int i = 0; i < s.Length; i++)
		{
			if(s[i] == '1')
			{	
				resposta++;
			}
		}

		System.Console.WriteLine(resposta);
	}
}
