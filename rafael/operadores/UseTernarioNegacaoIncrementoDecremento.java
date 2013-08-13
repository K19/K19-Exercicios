class UseTernarioNegacaoIncrementoDecremento {
	public static void main(String[] args) {	
		int a = 10;
		int b = 8;

		System.out.println((a < b) ? a : b);
		System.out.println(!(a < b) ? "Marcelo" : "Jonas");
		System.out.println((a < b) ? a : ++b);
		System.out.println(!(--a == b) ? a : b + 1);
	}
}
