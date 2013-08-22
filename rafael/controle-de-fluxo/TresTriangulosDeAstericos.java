class TresTriangulosDeAstericos {
	public static void main(String[] args) {
		for(int i = 0; i < 3; i++) {
			String s = "*";
			for(int j = 0; j < 6; j++) {
				System.out.println(s);
				s += "*";
			}
		}
	}
}
