
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
function calcularImc(peso, altura) {
    return peso / (Math.pow(altura,2));
    }

function classificarImc(imc){
        if (imc < 18.5){
            return 'Abaixo do peso';
        } else if (imc >=18.5 && imc <= 25) { 
            return 'peso normal';
        } else if (imc > 25 && imc <= 30 ){
            return 'acima do peso';
        } else if ( imc >30 && imc <=40) {
            return 'obeso';
        } else if (imc > 40 ){
            return 'obesidade grave';
        }
        }

        function main(){
            const peso = 92;
            const altura = 1.78;

            const IMC = calcularImc(peso,altura);
            console.log(classificarImc(IMC));
        }

main();




