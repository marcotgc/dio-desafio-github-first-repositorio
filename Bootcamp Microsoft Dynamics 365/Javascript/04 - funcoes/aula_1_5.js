/*
calcular o que deve ser pago por um produto, considerando o preço
normal de etiqueta e a escolha da condição de pagamento.
codigo condição de pagamento:
 1- à vista Débito - recebe 10% de desconto
 2- à vista no dinheiro ou PIX, recebe 15% de desconto.
 3- em duas vezes, preço normal de etiqueta sem juros.
 4- acima de 2 vezes, preço normal de etiqueta mais juros de 10%
 
 
*/


function calcularvalorPagar(precoEtiq,condPagamento){
    let valorPagar = 0;

    if (condPagamento === 1 ){
        valorPagar = precoEtiq -(precoEtiq * 0.1);
    } else if (condPagamento === 2) { 
        valorPagar = precoEtiq - (precoEtiq * 0.15);
    } else if (condPagamento === 3 ){
        valorPagar = precoEtiq;
    } else if ( condPagamento === 4) {
        valorPagar = precoEtiq +(precoEtiq * 0.1);
    }
    console.log('valor a pagar: '+ valorPagar);

}





// Main
(function (){
    calcularvalorPagar(100,1);
    calcularvalorPagar(100,2);
    calcularvalorPagar(100,3);
    calcularvalorPagar(100,4);
    
})

();
