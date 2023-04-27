using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{

    // classe Pessoa
    // atributos Nome, Idade
    // método - Apresentar

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        

        //criar um metodo - acao que a pessoa pode realizar

        public void Apresentar()
        {
            
            Console.WriteLine($"Olá meu nome é {Nome} \n e tenho {Idade} anos");
        }
    }
}