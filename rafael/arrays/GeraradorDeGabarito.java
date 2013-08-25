class GeraradorDeGabarito {
	public static void main(String[] args) {
		int[] gabarito = new int[10];
		for(int i = 0; i < gabarito.length; i++) {
			gabarito[i] = (int)(Math.random() * 3 + 1);
			System.out.print(gabarito[i] + " ");
		}
		System.out.println("gabarito");
	}
}
