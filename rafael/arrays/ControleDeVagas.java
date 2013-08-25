class ControleDeVagas {
	public static void main(String[] args) {
		boolean[][] vagas = new boolean[4][10];
		for(int i = 0; i < vagas.length; i++) {
			for(int j = 0; j < vagas[i].length; j++) {
				vagas[i][j] = Math.random() < 0.5;
				System.out.print(vagas[i][j] ?  "- " : "X ");
			}
			System.out.println("andar " + (i + 1));
		}
	}
}
