
//identificar o namespace onde a classe encontra-se.
using ExemploFundamentos.Models;


/*
int quantidadeEmEstoque = 3;
int quantidadeCompra = 40;
bool possivelVenda = quantidadeEmEstoque > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


// condicao com 3 caminhos
// == um valor é igual a outro valor
if (quantidadeCompra == 0 )
{
    Console.WriteLine("Venda Inválida");
}
else if(possivelVenda) //continuacao do if,
{ 
    Console.WriteLine("Venda realizada.");
}
else // else final do if do inicio.
{
     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}



Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

if (letra == "a" ||
    letra == "e" ||
    letra == "i")
    {
        Console.WriteLine ("Vogal");
    }
else
{ 
    Console.WriteLine ("não é Vogal");
}

switch (letra)
{
  case "a":
  case "e":
  case "i":
  case "o":
  case "u":
    Console.WriteLine ("Vogal");
    break;
default: 
    Console.WriteLine("não é uma vogal");
    break;
}



bool eMaiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = false;

if (eMaiorDeIdade || possuiAutorizacaoDoResponsavel) {
    Console.WriteLine("entrada liberada");
    }
else {
            Console.WriteLine("entrada nao permitida");
    }


Calculadora calc = new Calculadora();
calc.Somar(3,2);
calc.Subtrair(3,2);
calc.Multiplicar(3,2);
calc.Dividir(3,2);
calc.Potencia(3,3);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);


//int numeroinc = numeroinc + 1;
//numeroinc ++;  //incrementa +1
//numeroinc --;  // decrementa -1



// for 
int numero = 5;

for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");

}
 
//while
int contando = 0;

while (contando <= 10)
{
Console.WriteLine($"{numero} x {contando} = {numero * contando}");
 contando++;
 // se quiser usar o break, para sair do while
  if (contando == 7) {
    break;
  }
}

int soma =0 , numero1 = 0;


// do while
do {
    Console.WriteLine("Digite um número ( 0 para");
    numero1 = Convert.ToInt32(Console.ReadLine());
    soma += numero1;

} while(numero1 != 0);
    Console.WriteLine($"Total da soma dos nros digitados = {soma}");



// criando um menu interativo
string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0); // sair do programa
            break;
        default:
            Console.WriteLine("opcao invalida");
            break;

    }

}
Console.WriteLine("o programa se encerrou");


*/


int[] arrayInteiros = new int[3];
arrayInteiros[0] = 72;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;
for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"posicao n {contador} - {arrayInteiros[contador]}"); 

}


//LISTAS 

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("RS");
listaString.Add("SC");

for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posicao n {contador} - {listaString[contador]}");
}

int contadorForeach = 0;

foreach(string item in listaString)
{
    
}