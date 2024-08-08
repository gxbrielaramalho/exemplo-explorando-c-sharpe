using exemplo_explorando_c_sharpe.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Gabriela";
p1.Sobrenome = "Ramalho";
p1.Idade = 20;

Pessoa p2 = new Pessoa();
p2.Nome = "Roberto";
p2.Sobrenome = "Guedes Queiroz";
p2.Idade = 32;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();







//Pessoa p1 = new Pessoa ();
//p1.Nome = "Gabi";
//p1.Idade = 31;
//p1.Apresentar();