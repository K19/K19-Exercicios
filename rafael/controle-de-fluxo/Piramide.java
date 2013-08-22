class Piramide {
	public static void main(String[] args) {
		int baseMaior = 7;

		for (int i = 1; i <= baseMaior; i += 2) {
			int espacos = (baseMaior - i) / 2;
			String linha = "";

			for (int j = 0; j < espacos; j++) {
				linha += " ";
			}

			for (int k = 0; k < i; k++) {
				linha += "*";
			}

			System.out.println(linha);
		}
	}
}
