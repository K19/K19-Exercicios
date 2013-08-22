class VerificaValorProduto {
	public static void main(String[] args) {
		double precoDoProduto1 = Math.random() * 1000;
		double precoDoProduto2 = Math.random() * 1000;

		System.out.println("O preço do produto 1 é: " + precoDoProduto1);
		System.out.println("O preço do produto 2 é: " + precoDoProduto2);

		if (precoDoProduto1 < precoDoProduto2) {
			System.out.println("O produto 1 é o mais barato");
		} else {
			if(precoDoProduto2 < precoDoProduto1) {
				System.out.println("O produto 2 é o mais barato");
			} else {
				System.out.println("Os preços dos dois produtos são iguais");
			}
		}
	}
}
