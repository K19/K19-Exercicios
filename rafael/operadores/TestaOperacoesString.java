class TestaOperacoesString {
	public static void main(String[] args) {
		String s = "Rafael Cosentino";
		
		System.out.println(s.charAt(7));
		
		System.out.println(s.contains("Cosentino"));
		System.out.println(s.contains("Hirata"));
		
		System.out.println(s.endsWith("Cosentino"));
		System.out.println(s.endsWith("Hirata"));
		
		System.out.println(s.startsWith("Rafael"));
		System.out.println(s.startsWith("Marcelo"));

		s = s.replaceAll("Rafael", "Jonas");
		System.out.println(s);

		System.out.println(s.substring(6));
		System.out.println(s.substring(0, 5));

		s = s.toUpperCase();
		System.out.println(s);

		s = s.toLowerCase();
		System.out.println(s);

		s = "     K19 Treinamentos     ";
		System.out.println(s.trim());
	}
}
