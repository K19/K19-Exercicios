class EscolheCaminho {
	public static void main(String[] args) {
		double valor = Math.random();

		System.out.println("VALOR: " + valor);

		if (valor < 0.5) {
			System.out.println("Vire à esquerda");

			valor = Math.random();
	
			System.out.println("VALOR: " + valor);
	
			if (valor < 0.5) {
				System.out.println("Vire à esquerda");
			} else {
				System.out.println("Vire à direita");
			}
	
		} else {
			System.out.println("Vire à direita");

			valor = Math.random();

			System.out.println("VALOR: " + valor);
	
			if (valor < 0.5) {
				System.out.println("Vire à esquerda");
			} else {
				System.out.println("Vire à direita");
			}
		}
	}
}
