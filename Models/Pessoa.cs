// Importa os namespaces necessários para o funcionamento do código.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Importa os namespaces necessários para o funcionamento do código.
using System;

namespace exemplo_explorando_c_sharpe.Models
{
    // Define uma classe chamada "Pessoa" dentro do namespace.
    public class Pessoa
    {
        // Declara uma variável privada do tipo string chamada "_nome".
        private string _nome;

        // Declara uma variável privada do tipo int chamada "_idade".
        private int _idade;

        // Declara uma variável privada do tipo string chamada "_sobrenome".
        private string _sobrenome;

        // Propriedade pública "Nome" para acessar e modificar o campo "_nome".
        public string Nome 
        { 
            // O método get retorna o valor de "_nome" convertido para letras maiúsculas.
            get => _nome.ToUpper();
            
            // O método set permite definir o valor de "_nome".
            set 
            {
                // Verifica se o valor é uma string vazia.
                if (string.IsNullOrWhiteSpace(value)) 
                {
                    // Se for vazio ou nulo, lança uma exceção informando que o nome não pode ser vazio.
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                // Se o valor não for vazio, atribui o valor à variável "_nome".
                _nome = value;
            }
        }

        // Propriedade pública "Sobrenome" para acessar e modificar o campo "_sobrenome".
        public string Sobrenome 
        { 
            // O método get retorna o valor de "_sobrenome" convertido para letras maiúsculas.
            get => _sobrenome.ToUpper();
            
            // O método set permite definir o valor de "_sobrenome".
            set 
            {
                // Verifica se o valor é uma string vazia.
                if (string.IsNullOrWhiteSpace(value)) 
                {
                    // Se for vazio ou nulo, lança uma exceção informando que o sobrenome não pode ser vazio.
                    throw new ArgumentException("O sobrenome não pode ser vazio.");
                }

                // Se o valor não for vazio, atribui o valor à variável "_sobrenome".
                _sobrenome = value;
            }
        }

        // Propriedade pública "Idade" para acessar e modificar o campo "_idade".
        public int Idade 
        { 
            // O método get retorna o valor de "_idade".
            get => _idade;
            
            // O método set permite definir o valor de "_idade".
            set 
            {
                // Verifica se o valor é menor que zero.
                if (value < 0) 
                {
                    // Se for menor que zero, lança uma exceção informando que a idade não pode ser negativa.
                    throw new ArgumentException("A idade não pode ser menor do que zero.");
                }

                // Se o valor for válido (maior ou igual a zero), atribui o valor à variável "_idade".
                _idade = value;
            } 
        }

        // Método público "Apresentar" que exibe o nome completo (nome e sobrenome) e a idade no console.
        public void Apresentar() 
        {
            // Exibe no console uma string formatada com o nome completo (Nome + Sobrenome) e a idade.
            Console.WriteLine($"Nome Completo: {Nome} {Sobrenome}, Idade: {Idade}");
        }
    }
}
