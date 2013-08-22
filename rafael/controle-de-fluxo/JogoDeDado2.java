class JogoDeDado2 {
	public static void main(String[] args) {
		int soma = 0;
		for(int i = 1; i <= 5; i++) {
			System.out.println("Lançamento: " + i);
			int numero = (int)(Math.random() * 6 + 1);

			System.out.println("Número: " + numero);

			if(numero % 2 == 0) {
				System.out.println("-----------------------");
				continue;
			}

			soma += numero;
		
			System.out.println("Soma: " + soma);
			System.out.println("-----------------------");

			if(soma > 9) {
				System.out.println("Você ganhou com " + i + " lançamentos");
				break;
			}
		}
	}
}
