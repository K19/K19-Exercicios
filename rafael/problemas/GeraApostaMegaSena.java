class GeraApostaMegaSena {
	public static void main(String[] args) {
		for(int i = 0; i < 10; i++) {
			int[] array = geraApostaMegaSena();
			System.out.print("Aposta " + (i + 1) + ": ");
			exibeArray(array);
		}
	}

	public static int[] geraApostaMegaSena() {
		int[] numeros = new int[60];
		for(int i = 0; i < numeros.length; i++) {
			numeros[i] = i + 1;
		}

		int[] aposta = new int[6];
		for(int i = 0; i < aposta.length; i++) {
			int j = aleatorio(i, numeros.length - 1);
			aposta[i] = numeros[j];
			troca(numeros, i, j);
		}

		return aposta;
	}

	public static int aleatorio(int i, int j) {
		return (int)(Math.random() * (j - i + 1)) + i;
	}

	public static void troca(int[] array, int i, int j) {
		int auxiliar = array[i];
		array[i] = array[j];
		array[j] = auxiliar;
	}

	public static void exibeArray(int[] array) {
		System.out.print("{");

		for(int i = 0; i < array.length - 1; i++) {
			System.out.print(array[i] + ", ");
		}
	
		System.out.println(array[array.length - 1] + "}");
	}
}
