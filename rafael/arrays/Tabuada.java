class Tabuada {
	public static void main(String[] args) {
		int[][] tabuada = new int[10][10];

		for (int i = 0; i < tabuada.length; i++) {
			for (int j = 0; j < tabuada[i].length; j++) {
				tabuada[i][j] = (i + 1) * (j + 1);
			}
		}

		for (int i = 0; i < tabuada.length; i++) {
			for (int j = 0; j < tabuada[i].length; j++) {
				System.out.println((i + 1) + " x " + (j + 1) + " = " + tabuada[i][j]);
			}
		}
	}
}
