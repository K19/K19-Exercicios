class ContaUns {
	public static void main(String[] args) {
		double numero = Math.random();
		System.out.println(numero);

		String s = "" + numero;
		int resposta = 0;		

		for(int i = 0; i < s.length(); i++) {
			if(s.charAt(i) == '1') {	
				resposta++;
			}
		}

		System.out.println(resposta);
	}
}
