for (var x = 1; x <= 80; x++) {
	var resto4 = x % 4;
	var resto7 = x % 7;

	if (resto4 == 0 || resto7 == 0) {
		console.log("*");
	} else {
		console.log(x);
	}
}