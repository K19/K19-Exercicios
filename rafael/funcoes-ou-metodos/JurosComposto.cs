class JurosComposto 
{
	static void Main() 
	{
		double reposta1 = calculaJurosComposto(10000, 0.1, 6);
		double reposta2 = calculaJurosComposto(20000, 0.05, 6);

		System.Console.WriteLine("Montante: " + reposta1);
		System.Console.WriteLine("Montante: " + reposta2);
	}

	static double calculaJurosComposto(double capital, double taxa, int periodo) 
	{
		double montante = capital * System.Math.Pow(1 + taxa, periodo);
		return montante;
	}
}
