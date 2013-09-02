class Aleatorio {
	public static void main(String[] args) {
		System.out.println("Sorteando no intervalo [0, 10]");
		for(int i = 0; i < 10; i++) {
			int numero = aleatorio(0, 10);
			System.out.println(numero);
		}
		
		System.out.println("\nSorteando no intervalo [-25, 10]");
		for(int i = 0; i < 10; i++) {
			int numero = aleatorio(-25, 10);
			System.out.println(numero);
		}
	}

	public static int aleatorio(int i, int j) {
		return (int)(Math.random() * (j - i + 1)) + i;
	}
}
