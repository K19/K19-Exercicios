class TestaOperacoesString 
{
	static void Main() 
	{
		string s = "Rafael Cosentino";
		
		System.Console.WriteLine(s[7]);
		
		System.Console.WriteLine(s.Contains("Cosentino"));
		System.Console.WriteLine(s.Contains("Hirata"));
		
		System.Console.WriteLine(s.EndsWith("Cosentino"));
		System.Console.WriteLine(s.EndsWith("Hirata"));
		
		System.Console.WriteLine(s.StartsWith("Rafael"));
		System.Console.WriteLine(s.StartsWith("Marcelo"));

		s = s.Replace("Rafael", "Jonas");
		System.Console.WriteLine(s);

		System.Console.WriteLine(s.Substring(6));
		System.Console.WriteLine(s.Substring(0, 5));

		s = s.ToUpper();
		System.Console.WriteLine(s);

		s = s.ToLower();
		System.Console.WriteLine(s);

		s = "     K19 Treinamentos     ";
		System.Console.WriteLine(s.Trim());
	}
}
