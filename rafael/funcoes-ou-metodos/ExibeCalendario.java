class ExibeCalendario {
	public static void main(String[] args) {

		exibeCalendario(10, 1984);

		exibeCalendario(4, 1985);

		exibeCalendario(12, 1982);

		exibeCalendario(2, 2000);

	}

	static boolean bissexto(int ano){
		return ano % 400 == 0 || (ano % 100 != 0 && ano % 4 == 0);
	}

	static int diaDaSemana(int dia, int mes, int ano) {
		int a = (14 - mes) / 12; 		
		int y = ano - a;
		int m = mes + 12 * a - 2;
		int q = dia + 31 * m / 12 + y + y / 4 - y / 100 + y / 400;
		int d = q % 7;

		return d;
	}

	static void exibeCalendario(int mes, int ano) {
		int[] dias = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		
		boolean b = bissexto(ano);

		if(b) {
			dias[1] = 29;
		}
		
		int d = diaDaSemana(1, mes, ano);

		System.out.println("Dom Seg Ter Qua Qui Sex Sab");
		
		// espaços da primeira semana
		for(int i = 0; i < d; i++) {
			System.out.print("    ");
		}

		for(int i = 1; i <= dias[mes - 1]; i++) {
			String dia = "" + i;			
			if(i < 10) {
				dia = "0" + dia;
			}

			System.out.print(" " + dia + " ");

			if((i + d) % 7 == 0) {
				System.out.println();
			}
		}
		System.out.println("\n----------------------------");
	}
}
