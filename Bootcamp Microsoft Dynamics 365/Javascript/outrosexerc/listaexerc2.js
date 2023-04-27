/*
formula do imc
IMC = peso / (altura * altura)

elaborar um algoritmo que dado o peso e a altura de um adulto
mostre sua condição de acordo com a tabela abaixo:

- abaixo de 18.5 - abaixo do peso
- entre 18.5 e 25 - peso normal
- entre 25 e 30 - acima do peso
- entre 30 e 40 - obeso
- acima de 40 - obesidade grave

*/
const peso = 63;
const altura = 1.75;
let IMC = 0;

IMC = peso / (Math.pow(altura,2));


if (IMC < 18.5){
    console.log('Abaixo do peso');
} else if (IMC >=18.5 && IMC <= 25) { 
    console.log('peso normal');
} else if (IMC > 25 && IMC <= 30 ){
    console.log('acima do peso');
} else if ( IMC >30 && IMC <=40) {
    console.log('obeso');
} else if (IMC > 40 ){
    console.log('obesidade grave');
}
