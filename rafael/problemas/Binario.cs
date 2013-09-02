class Binario 
{
	static void Main() 
	{
		for(int i = 1; i < 100; i++) 
		{
			string s = binario(i);
			System.Console.WriteLine(i + " em binário " + s);
		} 
	}

	static string binario(int x) 
	{
		string y = "";
		while(x > 0) 
		{
			y = x % 2 + y;
			x = x / 2;
		}
		return y;
	}
}
