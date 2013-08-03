class TestaFormatacao {
	public static void main(String[] args) {
		String nome = "Jonas Hirata";
		int idade = 30;
		double peso = 49.7345;

		System.out.printf("O %1$s tem %2$d anos e pesa %3$.2f kg\n", nome, idade, peso);
	}
}
