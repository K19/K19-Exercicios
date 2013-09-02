class Embaralha {
	public static void main(String[] args) {
		System.out.println("Original");
		int[] array = {-10, 37, 101, 28, -4};
		exibeArray(array);

		System.out.println("\nEmbaralhando...");
		embaralha(array);
		exibeArray(array);

		System.out.println("\nEmbaralhando...");
		embaralha(array);
		exibeArray(array);

		System.out.println("\nEmbaralhando...");
		embaralha(array);
		exibeArray(array);
	}

	public static void embaralha(int[] array) {
		for(int i = 0; i < array.length; i++) {
			int j = aleatorio(i, array.length - 1);
			troca(array, i, j);
		}
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
