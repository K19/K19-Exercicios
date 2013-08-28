class JurosComposto {
	public static void main(String[] args) {
		double reposta1 = calculaJurosComposto(10000, 0.1, 6);
		double reposta2 = calculaJurosComposto(20000, 0.05, 6);

		System.out.println("Montante: " + reposta1);
		System.out.println("Montante: " + reposta2);
	}

	static double calculaJurosComposto(double capital, double taxa, int periodo) {
		double montante = capital * Math.pow(1 + taxa, periodo);
		return montante;
	}
}
