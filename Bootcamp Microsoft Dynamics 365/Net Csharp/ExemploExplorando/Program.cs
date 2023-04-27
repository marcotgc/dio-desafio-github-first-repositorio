// minha classe Pessoa está dentro de models, precisamos 
// importar o namespace... 

using ExemploExplorando.Models;
using System.Globalization;

/* CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-Br");

//Pessoa p1 = new Pessoa();
//p1.Nome = "Marco";
//p1.Sobrenome = "Cini";
//p1.Idade = 53;
//p1.Apresentar();

Pessoa p1 = new Pessoa(nome: "Marco" , sobrenome: "Cini");
Pessoa p2 = new Pessoa(nome: "Julio" , sobrenome: "Villwock Cini");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

// CONCATENACAO DE VALORES
string numero1 = "10";
string numero2 = "20";
string resultado = numero1 +numero2;
Console.WriteLine(resultado);  //1020

//FORMATANDO VALORES MONETARIOS
//currency - C  olha a regiao do windows que estamos "regional format"
decimal valorMonetario = 1582.40M;
Console.WriteLine($"Brasil {valorMonetario:C2}");

// ALTERAR A LOCALIZACAO DO SISTEMA PARA EXIBIR EM OUTRO FORMATO:
Console.WriteLine($"Usa {valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-us"))}" );

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));

// formatar o tipo datetime
//DateTime.Now - é do tipo get - só retorna a data, nao pode ser alterada.
DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/mm/yyyy HH:mm"));
// HH = 24h   HH - 12H
Console.WriteLine(data.ToShortDateString());

// parse - converter de string para date
DateTime data1 = DateTime.Parse("20/04/2023 14:39");
Console.WriteLine(data1);

string dataString = "20-04-2023 18:00";

bool sucesso = DateTime.TryParseExact(dataString,
"dd-MM-yyyy HH:mm",
CultureInfo.InvariantCulture,
DateTimeStyles.None, out DateTime data3);
if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data3}");
}
else 
{
    Console.WriteLine($"{dataString} não é uma data válida");

}

*/ 
//tratamento de excecoes, trata e segue a execucao.
/*

try 
{

    string[] linhas = File.ReadAllLines("Models/Arquivos/arquivo_Leitura.txt");

    foreach(string linha in linhas)
    {
    Console.WriteLine(linha);
    }
}
catch(FileNotFoundException ex)
{
    Console.WriteLine("arquivo nao encontrado");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine("caminho da pasta nao encontrado");
}
catch(Exception ex) 
{
    Console.WriteLine("Ocorreu uma exceção genérica. Mensage de erro:" + ex.Message);
}finally 
{


}
Console.WriteLine("Chegou até aqui sem erros");
*/

//new ExemploExcecao().Metodo1();

// FILA ---------------------------------
Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);

}

// remover um elemento da fila -sempre remove o primeiro elemento que entrou.
// regra da fila.
 Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
 foreach(int item in fila)
{
    Console.WriteLine(item);

}

// PILHA  - REMOVE O ELEMENTO DO TOPO - FIFO

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item1 in pilha)
{
    Console.WriteLine(item1);

}
Console.WriteLine($"removendo elemento do topo:{pilha.Pop()}");


