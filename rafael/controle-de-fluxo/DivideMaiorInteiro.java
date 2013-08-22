class DivideMaiorInteiro {
	public static void main(String[] args) {
		int numero = 2147483647;

		while (numero >= 100) {
			numero /= 2;
			System.out.println(numero);
		}
	}
}
