class ComparaValores {
	public static void main(String[] args) {
		double primeiro = Math.random();
		double segundo = Math.random();
	
		System.out.println("Primeiro: " + primeiro);
		System.out.println("Segundo: " + segundo);

		if(primeiro > segundo) {
			System.out.println("Primeiro > Segundo");
		} else if(primeiro < segundo) {
			System.out.println("Segundo > Primeiro");
		} else {
			System.out.println("Primeiro = Segundo");
		}
	}
}
