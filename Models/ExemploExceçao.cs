using System;

namespace exemplo_explorando_c_sharpe.Models
{
    public class ExemploExceçao
    {
        public void VerificarIdade(int idade)
        {
            if (idade < 0)
            {
                throw new ArgumentOutOfRangeException("A idade não pode ser negativa.");
            }
            else if (idade > 120)
            {
                throw new ArgumentOutOfRangeException("A idade não pode ser maior que 120 anos.");
            }
            else
            {
                Console.WriteLine($"Idade válida: {idade}");
            }
        }

        public static void Main(string[] args)
        {
            ExemploExceçao exemplo = new ExemploExceçao();

            try
            {
                exemplo.VerificarIdade(150);  // Testando com uma idade inválida
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            try
            {
                exemplo.VerificarIdade(25);  // Testando com uma idade válida
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
