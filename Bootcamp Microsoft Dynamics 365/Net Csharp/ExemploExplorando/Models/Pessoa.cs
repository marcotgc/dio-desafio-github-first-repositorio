using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
    //criando um construtor:
    //- ele tem o mesmo nome de sua classe.
    // - nao retorna nada.
    // fizemos 2 construtores - 1 recebe nome, sobrenome e o outro permite 
    // que nao recebamos nada.
        public Pessoa()
        {
        }
        public Pessoa(string nome, string sobrenome)
         {
            Nome = nome;
            Sobrenome = sobrenome;
         }


     // classe pessoa com 2 propriedades(possui get e set)
    
        private string _nome;
        private int _idade;


        public string Nome
        { 
            get => _nome.ToUpper();
                       
            set
            { 
                if (value == "")  //value eh o argumento que esta recebendo o Nome
                {
                    throw new ArgumentException("o nome não pode ser vazio");
                }
                _nome = value;
            }
            
        }



        public int Idade
        { 
            get  => _idade;  
             // return _idade - mesma coisa
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A Idade nao pode ser menor que zero");
                }
                _idade = value;
            }           
            
        }

                public string Sobrenome { get; set; }

                public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

// juntar o nome e sobrenome.
// get  - apenas retorna o valor, nao conseguimos atribuir valor nenhum.
       

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}