class Troca {
	public static void main(String[] args) {
		System.out.println("Original");
		int[] array = {-10, 37, 101, 28, -4};
		exibeArray(array);

		System.out.println("\nTroca 0 e 2");
		troca(array, 0, 2);
		exibeArray(array);

		System.out.println("\nTroca 1 e 3");
		troca(array, 1, 3);
		exibeArray(array);
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
