function impMeuNome(nome){
 console.log('meu nome é '+ nome);
}


function verificaMaiorIdade(idade){
if (idade >=18 ){
    console.log(' é maior de 18 anos');
}else {
    console.log(' é menor que 18 anos');
}
}


// Main
(function (){
    impMeuNome('Marco Tulio');
    verificaMaiorIdade(13);
})

();