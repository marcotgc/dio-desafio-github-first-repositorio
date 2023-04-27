/*calcular o valor de uma viagem
você terá 5 variáveis, sendo elas:
1 - preço do etanol
2 - preço da gasolina
3- o tipo de combustivel que está no carro
4 - Km/l por tipo de combustivel
5 - distancia em KM da viagem

Imprima no console o valor que será gasto para realizar a viagem

*/
const precoEtanol = 4.5;
const precoGasolina = 6.66;
const tipoCombustivel = "Gasolina";
const kmLitroTipoComb = 10;
const distanciaViagemKm =100;
let valorGasto = 0;

if (tipoCombustivel==='Alcool'){
  valorGasto = (distanciaViagemKm/kmLitroTipoComb)*precoEtanol;
} else{ 
    valorGasto = (distanciaViagemKm/kmLitroTipoComb)*precoGasolina;
}

console.log('valor gasto: '+ valorGasto.toFixed(2));