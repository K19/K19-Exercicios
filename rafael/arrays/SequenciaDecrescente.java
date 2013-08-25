class SequenciaDecrescente {
	public static void main(String[] args) {
		int[] array = new int[10];

		for (int i = 0; i < array.length; i++) {
			array[i] = array.length - 1 - i;
		}

		for (int i = 0; i < array.length; i++) {
			System.out.println(array[i]);
		}
	}
}
