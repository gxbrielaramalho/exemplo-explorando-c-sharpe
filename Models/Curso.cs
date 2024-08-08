using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_explorando_c_sharpe.Models
{
    // Define uma classe chamada "Curso" dentro do namespace.
    public class Curso
    {
        // Propriedade pública "Nome" que armazena o nome do curso.
        public string Nome { get; set; }

        // Propriedade pública "Alunos" que armazena uma lista de objetos do tipo "Pessoa".
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>(); // Inicializa a lista para evitar null reference.

        // Método público "AdicionarAluno" que recebe um objeto do tipo "Pessoa" como parâmetro.
        public void AdicionarAluno(Pessoa aluno)
        {
            // Adiciona o aluno à lista de alunos.
            Alunos.Add(aluno);
        }

        // Método público "ObterQuantidadeDeAlunosMatriculados" que retorna a quantidade de alunos na lista.
        public int ObterQuantidadeDeAlunosMatriculados() 
        {
            // Declara uma variável "quantidade" e armazena o número de alunos na lista "Alunos".
            int quantidade = Alunos.Count;

            // Retorna a quantidade de alunos matriculados.
            return quantidade;
        }

        // Método público "RemoverAluno" que remove um aluno da lista "Alunos" e retorna se a operação foi bem-sucedida.
        public bool RemoverAluno(Pessoa aluno) 
        {
            // Remove o aluno específico da lista "Alunos" e retorna true se a remoção foi bem-sucedida, ou false se não foi.
            return Alunos.Remove(aluno);
        }

        // Método público "ListarAlunos" que exibe os nomes completos de todos os alunos na lista.
        public void ListarAlunos() 
        {
            // Verifica se há alunos na lista antes de tentar listar
            if (Alunos.Any())
            {
                // Itera sobre cada aluno na lista "Alunos".
                foreach (Pessoa aluno in Alunos) 
                {
                    // Exibe o nome completo do aluno no console.
                    Console.WriteLine(aluno.Nome); // Corrigido para "Nome" ao invés de "NomeCompleto"
                }
            }
            else
            {
                // Se não houver alunos, exibe uma mensagem informando.
                Console.WriteLine("Não há alunos matriculados.");
            }
        }
    }
}
