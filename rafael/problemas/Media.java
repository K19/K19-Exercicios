class Media {
	public static void main(String[] args) {
		double[] array = {-10.7, 37.8, 101.1, 28, -4.9};

		double media = media(array);

		System.out.println("A média dos elementos do array é: " + media);
	}

	public static double media(double[] array) {
		double soma = soma(array);
		double media = soma / array.length;
		return media;
	}

	public static double soma(double[] array) {
		double soma = 0;

		for(int i = 0; i < array.length; i++) {
			soma += array[i];
		}

		return soma;
	}
}
