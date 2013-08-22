class CartoesDeEstacionamento {
	public static void main(String[] args) {
		for(int i = 1; i <= 3; i++) {
			for(int j = 1; j <= 9; j++) {
				for(int k = 1; k <= 4; k++) {
					System.out.println("BLOCO: " + i + " APTO: " + (j * 10 + k)); 
				}
			}
		}
	}
}
