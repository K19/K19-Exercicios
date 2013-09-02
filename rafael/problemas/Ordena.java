class Ordena {
	public static void main(String[] args) {
		System.out.println("Original");
		int[] array = {-10, 37, 101, 28, -4};
		exibeArray(array);

		System.out.println("\nOrdenando...");
		ordena(array);
		exibeArray(array);
	}

	public static void ordena(int[] array) {
		for(int i = 0; i < array.length; i++) {
			int menor = menor(array, i);
			troca(array, i, menor);
		}
	}

	public static int menor(int[] array, int inicio) {
		int menor = inicio;

		for(int i = inicio + 1; i < array.length; i++) {
			if(array[menor] > array[i]) {
				menor = i;
			}
		}

		return menor;
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
