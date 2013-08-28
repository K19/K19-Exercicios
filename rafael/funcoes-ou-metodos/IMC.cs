class IMC 
{
	static void Main() 
	{
		double amandaIMC = calculaIMC(52.6, 1.61);
		double joyceIMC = calculaIMC(54.1, 1.59);

		string amandaSituacao = calculaResultadoIMC(amandaIMC);
		string joyceSituacao = calculaResultadoIMC(joyceIMC);

		System.Console.WriteLine("Amanda IMC: " + amandaIMC + " - " + amandaSituacao);
		System.Console.WriteLine("Joyce IMC: " + joyceIMC + " - " + joyceSituacao);
	}

	static double calculaIMC(double peso, double altura) 
	{
		return peso / (altura * altura);
	}

	static string calculaResultadoIMC(double imc) 
	{
		if(imc < 17) 
		{
			return "Muito abaixo do peso";
		} 
		else if(imc < 18.5) 
		{
			return "Abaixo do peso";
		} 
		else if(imc < 25) 
		{
			return "Peso normal";
		} 
		else if(imc < 30) 
		{
			return "Acima do peso";
		} 
		else if(imc < 35) 
		{
			return "Obsesidade I";
		} 
		else if(imc < 40) 
		{
			return "Obsesidade II - severa";
		} 
		else 
		{
			return "Obsesidade III - mórbida";
		}
	}
}
