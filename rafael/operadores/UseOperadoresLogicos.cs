class UseOperadoresLogicos 
{
	static void Main() 
	{		
		int q = 10;
		int w = 5;
		int e = 8;
		int r = 11;

		System.Console.WriteLine(q > w | e < r);
		System.Console.WriteLine(q > r || e < w);
		System.Console.WriteLine(q > e & w < r);
		System.Console.WriteLine(q > w && r < e);
		System.Console.WriteLine(q > w ^ e < r);
	}
}
