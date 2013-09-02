class Inverte {
	public static void main(String[] args) {
		System.out.println("Original");
		int[] array = {-10, 37, 101, 28, -4};
		exibeArray(array);

		System.out.println("\nInvertendo...");
		inverte(array);
		exibeArray(array);
	}

	public static void inverte(int[] array) {
		int i = 0;
		int j = array.length - 1;

		while(i < j) {
			troca(array, i, j);
			i++;
			j--;
		}
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
