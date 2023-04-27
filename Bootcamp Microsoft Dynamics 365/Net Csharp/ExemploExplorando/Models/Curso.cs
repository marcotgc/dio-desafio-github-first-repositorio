using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        // lista eh uma colecao do tipo Pessoa.
        public List<Pessoa> Alunos { get; set; }

        // void nao retorna nada. ou seja nao precisa do return.
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        // tipo int, necessita retornar um valor..
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }
    // ou 
    // public bool RemoverAluno(Pessoa aluno)
    //  {
    //    Alunos.Remove(aluno);
    //    return true;
    //   }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            for (int count = 0; count < Alunos.Count; count ++)
            {
                // interpolação de strings $".. "
                Console.WriteLine($" nº {count + 1} - {Alunos[count].NomeCompleto}");
                // concatenacao de strings
                string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                Console.WriteLine(texto);
                
            }

        }



    }
      
}