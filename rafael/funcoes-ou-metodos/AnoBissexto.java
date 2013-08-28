class AnoBissexto {
	public static void main(String[] args) {
		boolean b = bissexto(2000);
		System.out.println("2000 " + b);

		b = bissexto(2012);
		System.out.println("2012 " + b);

		b = bissexto(2025);
		System.out.println("2025 " + b);

		b = bissexto(2100);
		System.out.println("2100 " + b);
	}

	static boolean bissexto(int ano){
		return ano % 400 == 0 || (ano % 100 != 0 && ano % 4 == 0);
	}
}
