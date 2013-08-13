class GeraParcelas 
{
	static void Main() 
	{	
		System.DateTime p = new System.DateTime(2015 , 8 , 15);
		System.Console.WriteLine(p.ToString("dd/MM/yyyy"));

		p = p.AddDays(30);
		System.Console.WriteLine(p.ToString("dd/MM/yyyy"));

		p = p.AddDays(30);
		System.Console.WriteLine(p.ToString("dd/MM/yyyy"));

		p = p.AddDays(30);
		System.Console.WriteLine(p.ToString("dd/MM/yyyy"));
	}
}
