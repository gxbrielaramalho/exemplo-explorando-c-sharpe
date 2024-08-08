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
            
            for (int count = 0; count < Alunos.Count; count++) 
            {
               string texto = "N° " + (count + 1) + ": " + Alunos[count].Nome + " " + Alunos[count].Sobrenome;
                Console.WriteLine(texto); // Exibe o nome completo do aluno
            }

           
           
        }
    }
}
