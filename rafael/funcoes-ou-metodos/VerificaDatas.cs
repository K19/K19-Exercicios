class VerificaDatas 
{
	static void Main() 
	{
		bool b = verificaData(29, 2, 2100);

		System.Console.WriteLine("29/02/2100 - " + b);			

		b = verificaData(29, 2, 2004);

		System.Console.WriteLine("29/02/2004 - " + b);

		b = verificaData(31, 4, 2000);

		System.Console.WriteLine("31/04/2000 - " + b);
	}

	static bool bissexto(int ano)
	{
		return ano % 400 == 0 || (ano % 100 != 0 && ano % 4 == 0);
	}

	static bool verificaData(int dia, int mes, int ano) 
	{
		int[] dias = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		
		bool b = bissexto(ano);

		if(b) 
		{
			dias[1] = 29;
		}

		return (dia >= 1 && dia <= dias[mes - 1]) && (mes >= 1 && mes <= 12) && ano >= 1;
	}
}
