var linha = "*";
for(var contador = 1; contador <= 8; contador++) {
	console.log(linha);
	var resto = contador % 4;
	if(resto == 0) {
		linha = "*";
	} else {
		linha += "*";
	}
}