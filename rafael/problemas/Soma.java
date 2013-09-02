class Soma {
	public static void main(String[] args) {
		double[] array = {-10.7, 37.8, 101.1, 28, -4.9};
		
		double soma = soma(array);

		System.out.println("A soma dos elementos do array é: " + soma);
	}

	public static double soma(double[] array) {
		double soma = 0;

		for(int i = 0; i < array.length; i++) {
			soma += array[i];
		}

		return soma;
	}
}
