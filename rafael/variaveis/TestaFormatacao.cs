class TestaFormatacao 
{
	static void Main() 
	{
		string nome = "Jonas Hirata";
		int idade = 30;
		double peso = 49.7345;

		System.Console.WriteLine("O {0} tem {1} anos e pesa {2:F2} kg", nome, idade, peso);
	}
}
