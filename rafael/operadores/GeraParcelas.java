class GeraParcelas {
	public static void main(String[] args) {	
		java.text.SimpleDateFormat sdf = new java.text.SimpleDateFormat("dd/MM/yyyy"); 
		
		java.util.Calendar p = new java.util.GregorianCalendar(2015 , 7 , 15) ;
		System.out.println(sdf.format(p.getTime()));

		p.add(java.util.Calendar.DAY_OF_MONTH, 30);
		System.out.println(sdf.format(p.getTime()));

		p.add(java.util.Calendar.DAY_OF_MONTH, 30);
		System.out.println(sdf.format(p.getTime()));

		p.add(java.util.Calendar.DAY_OF_MONTH, 30);
		System.out.println(sdf.format(p.getTime()));
	}
}
