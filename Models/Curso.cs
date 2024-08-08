using System;
using System.Collections.Generic;
using System.Linq;

namespace exemplo_explorando_c_sharpe.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();

        // Construtor que exige Nome como parâmetro
        public Curso(string nome)
        {
            Nome = nome;
        }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados() 
        {
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa aluno) 
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos() 
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            if (Alunos.Any())
            {
                foreach (Pessoa aluno in Alunos) 
                {
                    aluno.Apresentar(); // Exibe o nome completo e a idade do aluno
                }
            }
            else
            {
                Console.WriteLine("Não há alunos matriculados.");
            }
        }
    }
}
