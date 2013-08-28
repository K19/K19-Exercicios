class IRPF {
	public static void main(String[] args) {
		double reposta1 = calculaIRPF(1350.57);
		double reposta2 = calculaIRPF(2150.37);
		double reposta3 = calculaIRPF(3378.98);
		double reposta4 = calculaIRPF(3956.12);
		double reposta5 = calculaIRPF(6200.15);

		System.out.println("IRPF 1: " + reposta1);
		System.out.println("IRPF 2: " + reposta2);
		System.out.println("IRPF 3: " + reposta3);
		System.out.println("IRPF 4: " + reposta4);
		System.out.println("IRPF 5: " + reposta5);
	}

	static double calculaIRPF(double renda) {
		if(renda <= 1710.18) {
			return 0;
		} else if(renda <= 2563.91) {
			return renda * 0.075 - 128.31;
		} else if(renda <= 3418.59) {
			return renda * 0.15 - 320.60;
		} else if(renda <= 4271.59) {
			return renda * 0.225 - 577.00;
		} else {
			return renda * 0.275 - 790.58;
		}
	}
}
