

const numero = 0;
/*
verifica se numero é par.
utilizando o resto da divisao %
*/
const numeroPar = (numero % 2)=== 0;
/*
== - ignora o tipo da variavel
(conversao implicita. 2 =='2')
=== - comparaçao correta, nao faz
a conversao implicita
*/

/*condicional if then else */

if (numeroPar ===0) {
    console.log('número invalido');
}else if (numeroPar) {
        console.log('e par');
    } else if (!numeroPar){
        console.log('Impar');
    } else {
        
    }
       