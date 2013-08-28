class Arrays {
	public static void main(String[] args) {
		int[] array1 = new int[5];
		int[] array2 = new int[10];

		preencheArray(array1);
		preencheArray(array2);

		exibeArray(array1);
		exibeArray(array2);

		int pares1 = contaPar(array1);
		int pares2 = contaPar(array2);

		System.out.println("Quantidade de pares do primeiro array: " + pares1);
		System.out.println("Quantidade de pares do segundo array: " + pares2);
	}

	static int contaPar(int[] array) {
		int pares = 0;
		for(int i = 0; i < array.length; i++) {
			if(array[i] % 2 == 0) {
				pares++;
			}
		}
		return pares;
	}

	static void preencheArray(int[] array) {
		for(int i = 0; i < array.length; i++) {
			array[i] = (int)(Math.random() * 100);
		}
	}

	static void exibeArray(int[] array) {
		System.out.println("Array: ");
		for(int i = 0; i < array.length; i++) {
			System.out.println("array[" + i + "] = " + array[i]);
		}
		System.out.println("------------------------------------");
	}
}
