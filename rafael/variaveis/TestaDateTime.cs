class TestaDateTime 
{
	static void Main() 
	{
		System.DateTime exatamenteAgora = System.DateTime.Now;
		System.DateTime fundacaoK19 = 
			new System.DateTime(2010, 7, 27, 10, 32, 15);

		string exatamenteAgoraFormatada = exatamenteAgora.ToString("dd/MM/yyyy HH:mm:ss");
		string fundacaoK19Formatada = fundacaoK19.ToString("dd/MM/yyyy HH:mm:ss");
		
		System.Console.WriteLine(exatamenteAgoraFormatada);
		System.Console.WriteLine(fundacaoK19Formatada);
	}
}
