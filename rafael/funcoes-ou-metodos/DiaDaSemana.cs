class DiaDaSemana 
{
	static void Main() 
	{
		int d1 = diaDaSemana(30, 10, 1984);

		int d2 = diaDaSemana(2, 4, 1985);

		int d3 = diaDaSemana(12, 12, 1982);

		string[] dias = 
		{
			"domingo", 
			"segunda",
			"terça",
			"quarta",
			"quinta",
			"sexta",
			"sábado"
		};

		System.Console.WriteLine("30/10/1984 foi " + dias[d1]);
		
		System.Console.WriteLine("2/4/1985 foi " + dias[d2]);
		
		System.Console.WriteLine("12/12/1982 foi " + dias[d3]);	
	}

	static int diaDaSemana(int dia, int mes, int ano) 
	{
		int a = (14 - mes) / 12; 		
		int y = ano - a;
		int m = mes + 12 * a - 2;
		int q = dia + 31 * m / 12 + y + y / 4 - y / 100 + y / 400;
		int d = q % 7;

		return d;
	}
}
