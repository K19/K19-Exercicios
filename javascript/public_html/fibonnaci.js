var penultimo = 0;
var ultimo = 1;

console.log(penultimo);
console.log(ultimo);

for(var contador = 0; contador < 28; contador++) {
	var proximo = penultimo + ultimo;
	console.log(proximo);

	penultimo = ultimo;
	ultimo = proximo;
}