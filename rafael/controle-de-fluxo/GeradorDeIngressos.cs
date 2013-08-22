class GeradorDeIngressos 
{
	static void Main() 
	{
		for(int i = 1; i <= 4; i++) 
		{
			for(int j = 1; j <= 20; j++) 
			{
				System.Console.WriteLine("Setor: " + i + " Cadeira: " + j);
			}
		}
	}
}
