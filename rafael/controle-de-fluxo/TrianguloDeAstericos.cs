class TrianguloDeAstericos
{
	static void Main()
	{
		string s = "*";
		for(int i = 0; i < 6; i++)
		{
			System.Console.WriteLine(s);
			s += "*";
		}
	}
}
