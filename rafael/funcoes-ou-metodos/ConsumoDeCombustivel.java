class ConsumoDeCombustivel {
	public static void main(String[] args) {
		double reposta1 = calculaConsumoLitroKilometro(131.679, 13.5);
		double reposta2 = calculaConsumoLitroKilometro(251.856, 21.6);

		System.out.println("Consumo: " + reposta1);
		System.out.println("Consumo: " + reposta2);
	}

	static double calculaConsumoLitroKilometro(double distancia, double combustivel) {
		double consumo = distancia/combustivel;
		return consumo;
	}
}
