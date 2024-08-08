using exemplo_explorando_c_sharpe.Models;
using System.Globalization;


try 
{
string [] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach (string linha in linhas) {
    Console.WriteLine(linha);
}
} catch(Exception ex) {
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}



























//using exemplo_explorando_c_sharpe.Models;

//class Program
//{
    //static void Main()
     //{
        // Cria um curso com o nome "Inglês"
       //  Curso curso = new Curso("Inglês");

        // Cria alguns alunos
        // Pessoa aluno1 = new Pessoa("João", "Silva", 20);
       //  Pessoa aluno2 = new Pessoa("Maria", "Oliveira", 22);

        // Adiciona os alunos ao curso
        // curso.AdicionarAluno(aluno1);
         //curso.AdicionarAluno(aluno2);

        // Lista os alunos do curso
        // curso.ListarAlunos();

        // Mostra a quantidade de alunos matriculados
         //Console.WriteLine($"Quantidade de alunos matriculados: {curso.ObterQuantidadeDeAlunosMatriculados()}");
   //  }
 //}