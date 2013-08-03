class TestaCalendar {
	public static void main(String[] args) {
		java.util.Calendar exatamenteAgora = java.util.Calendar.getInstance();
		java.util.Calendar fundacaoK19 = 
			new java.util.GregorianCalendar(2010, 7, 27, 10, 32, 15);

		java.text.SimpleDateFormat sdf = 
			new java.text.SimpleDateFormat("dd/MM/yyyy HH:mm:ss");

		String exatamenteAgoraFormatada = sdf.format(exatamenteAgora.getTime());
		String fundacaoK19Formatada = sdf.format(fundacaoK19.getTime());
		
		System.out.println(exatamenteAgoraFormatada);
		System.out.println(fundacaoK19Formatada);
	}
}
