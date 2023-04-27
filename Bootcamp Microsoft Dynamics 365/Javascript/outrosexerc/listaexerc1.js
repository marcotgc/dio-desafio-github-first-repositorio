/*
dadas 3 notas de um aluno, calular e imprimir a sua media conforme
a tabela abaixo:
Media = ( nota1+ nota2+ nota3)/3;
classificação:
 - media menor que 5 - reprovado
 - media entre 5 e 7 - recuperação
 - media acima de 7 - passou de semestre.
*/
const nota1 = 7;
const nota2 = 8;
const nota3 = 7;

let mediaAnual = 0;

mediaAnual = (nota1 + nota2 + nota3)/3;

if (mediaAnual < 5){
    console.log(mediaAnual.toFixed(2)+ ' reprovado');
} else if (mediaAnual >=5 && mediaAnual <= 7) { 
    console.log(mediaAnual.toFixed(2) + ' recuperacao');
} else if (mediaAnual > 7 ){
    console.log(mediaAnual.toFixed(2) +' aprovado' );
} else {}
