class ADivisivelPorB {
	public static void main(String[] args) {
		int a = (int)(Math.random() * 1000);
		int b = (int)(Math.random() * 20);

		System.out.println("a: " + a);
		System.out.println("b: " + b);

		if (a % b == 0) {
			System.out.println("É divisível");
		} else {
			System.out.println("Não é divisível");
		}
	}
}
