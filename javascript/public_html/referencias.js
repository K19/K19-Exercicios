var curso = {sigla: "K11", nome: "Orientação a Objetos em Java"};

// exibe K11
console.log(curso.sigla);

// exibe Orientação a Objetos em Java
console.log(curso.nome);

var x = curso;

x.sigla = "K12";
x.nome = "Desenvolvimento Web com JSF2 e JPA2";

// exibe K12
console.log(curso.sigla);

// exibe Desenvolvimento Web com JSF2 e JPA2
console.log(curso.nome);