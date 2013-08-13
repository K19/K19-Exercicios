class UseOperadoresLogicos {
	public static void main(String[] args) {	
		int q = 10;
		int w = 5;
		int e = 8;
		int r = 11;

		System.out.println(q > w | e < r);
		System.out.println(q > r || e < w);
		System.out.println(q > e & w < r);
		System.out.println(q > w && r < e);
		System.out.println(q > w ^ e < r);
	}
}
