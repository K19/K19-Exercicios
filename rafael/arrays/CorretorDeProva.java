class CorretorDeProva {
	public static void main(String[] args) {
		int[] gabarito = new int[10];

		for(int i = 0; i < gabarito.length; i++) {
			gabarito[i] = (int)(Math.random() * 3 + 1);
			System.out.print(gabarito[i] + " ");
		}
		System.out.println("gabarito");

		int[][] respostas = new int[5][10];

		for(int i = 0; i < respostas.length; i++) {
			for(int j = 0; j < respostas[i].length; j++) {
				respostas[i][j] = (int)(Math.random() * 3 + 1);
				System.out.print(respostas[i][j] + " ");
			}
			System.out.println("aluno " + (i + 1));
		}
		
		System.out.println("Resultado:");
		for(int i = 0; i < respostas.length; i++) {
			int acertos = 0;
			for(int j = 0; j < respostas[i].length; j++) {
				if(gabarito[j] == respostas[i][j]) {
					acertos++;
				}
			}
			System.out.println("Aluno " + (i + 1) + ": " + acertos);
		}
	}
}
