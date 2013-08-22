class JogoDaSomaImpar {
	public static void main(String[] args) {
		int soma = 0;
		int quantidadeDeSeis = 0;		

		for(int i = 0; i < 10; i++) {
			int numero = (int)(Math.random() * 6 + 1);

			System.out.println("Número: " + numero);

			if(numero == 1) {
				continue;
			}

			if(numero == 6) {
				quantidadeDeSeis++;
			}

			if(quantidadeDeSeis == 2) {
				System.out.println("Dois seis! Você perdeu!");
				break;
			}

			soma += numero;
		}

		if(quantidadeDeSeis != 2) {
			System.out.println("Soma: " + soma);
			if(soma % 2 != 0) {
				System.out.println("Soma ímpar! Você ganhou");
			} else {
				System.out.println("Soma par! Você perdeu");
			}
		}
	}
}
