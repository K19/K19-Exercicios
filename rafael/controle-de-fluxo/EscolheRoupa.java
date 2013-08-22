class EscolheRoupa {
	public static void main(String[] args) {
		double valor = Math.random();

		if (valor < 0.5) {
			System.out.println("camiseta preta");
		} else {
			System.out.println("camiseta vermelha");
		}

		valor = Math.random();

		if (valor < 0.5) {
			System.out.println("calça jeans");
		} else {
			System.out.println("bermuda");
		}

		valor = Math.random();

		if (valor < 0.5) {
			System.out.println("tênis");
		} else {
			System.out.println("sapato");
		}

		valor = Math.random();

		if (valor < 0.5) {
			System.out.println("boné");
		} else {
			System.out.println("óculos");
		}
	}
}
