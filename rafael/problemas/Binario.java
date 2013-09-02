class Binario {
	public static void main(String[] args) {
		for(int i = 1; i < 100; i++) {
			String s = binario(i);
			System.out.println(i + " em binário " + s);
		} 
	}

	public static String binario(int x) {
		String y = "";
		while(x > 0) {
			y = x % 2 + y;
			x = x / 2;
		}
		return y;
	}
}
