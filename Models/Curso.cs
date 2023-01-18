using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
      public string Nome { get; set; }  
      public List<Pessoa> Alunos { get; set; } 

      public void AdicionarAluno(Pessoa aluno)
      {
        Alunos.Add(aluno);
      }
      public int ObterQuantidadeDeAlunosMatriculados()
      {
            int quantidade = Alunos.Count;
            //o return indica que chegou ao final do meu método, e que irá me retornar alguma coisa
            return quantidade;
        }
        public bool Removeraluno(Pessoa aluno)
        {
            //Um método pode ter um retorno do resultado de outro método
           return  Alunos.Remove(aluno);
       
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;
                Console.WriteLine(texto);
            }
            
        }
        }
}