class AchaMaiorOuMenor {
	public static void main(String[] args) {
		double[] array = {-10.7, 37.8, 101.1, 28, -4.9};

		int posicaoDoMaior = maior(array);
		System.out.println("O maior valor do array é: " + array[posicaoDoMaior]);
		System.out.println("Esse valor está na posição: " + posicaoDoMaior);

		int posicaoDoMenor = menor(array);
		System.out.println("O menor valor do array é: " + array[posicaoDoMenor]);
		System.out.println("Esse valor está na posição: " + posicaoDoMenor);
	}

	public static int maior(double[] array) {
		int posicaoDoMaior = 0;

		for(int i = 1; i < array.length; i++) {
			if(array[posicaoDoMaior] < array[i]) {
				posicaoDoMaior = i;
			}
		}

		return posicaoDoMaior;
	}

	public static int menor(double[] array) {
		int posicaoDoMenor = 0;

		for(int i = 1; i < array.length; i++) {
			if(array[posicaoDoMenor] > array[i]) {
				posicaoDoMenor = i;
			}
		}

		return posicaoDoMenor;
	}
}
