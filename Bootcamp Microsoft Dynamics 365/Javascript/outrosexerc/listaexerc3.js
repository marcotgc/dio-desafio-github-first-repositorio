/*
calcular o que deve ser pago por um produto, considerando o preço
normal de etiqueta e a escolha da condição de pagamento.
codigo condição de pagamento:
 1- à vista Débito - recebe 10% de desconto
 2- à vista no dinheiro ou PIX, recebe 15% de desconto.
 3- em duas vezes, preço normal de etiqueta sem juros.
 4- acima de 2 vezes, preço normal de etiqueta mais juros de 10%
 
 
*/

const precoEtiqueta = 100;
let valorPagar = 0;
let condicaoPagamento = 0;

condicaoPagamento = 4;

if (condicaoPagamento === 1 ){
    valorPagar = precoEtiqueta -(precoEtiqueta * 0.1);
} else if (condicaoPagamento === 2) { 
    valorPagar = precoEtiqueta - (precoEtiqueta * 0.15);
} else if (condicaoPagamento === 3 ){
    valorPagar = precoEtiqueta;
} else if ( condicaoPagamento === 4) {
    valorPagar = precoEtiqueta +(precoEtiqueta * 0.1);
}
console.log('valor a pagar: '+ valorPagar);