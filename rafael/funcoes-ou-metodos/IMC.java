class IMC {
	public static void main(String[] args) {
		double amandaIMC = calculaIMC(52.6, 1.61);
		double joyceIMC = calculaIMC(54.1, 1.59);

		String amandaSituacao = calculaResultadoIMC(amandaIMC);
		String joyceSituacao = calculaResultadoIMC(joyceIMC);

		System.out.println("Amanda IMC: " + amandaIMC + " - " + amandaSituacao);
		System.out.println("Joyce IMC: " + joyceIMC + " - " + joyceSituacao);
	}

	static double calculaIMC(double peso, double altura) {
		return peso / (altura * altura);
	}

	static String calculaResultadoIMC(double imc) {
		if(imc < 17) {
			return "Muito abaixo do peso";
		} else if(imc < 18.5) {
			return "Abaixo do peso";
		} else if(imc < 25) {
			return "Peso normal";
		} else if(imc < 30) {
			return "Acima do peso";
		} else if(imc < 35) {
			return "Obsesidade I";
		} else if(imc < 40) {
			return "Obsesidade II - severa";
		} else {
			return "Obsesidade III - mórbida";
		}
	}
}
