class GeraradorDeRespostasAleatorias {
	public static void main(String[] args) {
		int[][] respostas = new int[5][10];
		for(int i = 0; i < respostas.length; i++) {
			for(int j = 0; j < respostas[i].length; j++) {
				respostas[i][j] = (int)(Math.random() * 3 + 1);
				System.out.print(respostas[i][j] + " ");
			}
			System.out.println("aluno " + (i + 1));
		}
	}
}
