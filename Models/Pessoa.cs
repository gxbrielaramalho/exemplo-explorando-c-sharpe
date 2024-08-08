// Importa os namespaces necessários para o funcionamento do código.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;

namespace exemplo_explorando_c_sharpe.Models
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;
        private int _idade;

        // Construtor que exige Nome, Sobrenome e Idade como parâmetros
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome; // Usa a propriedade Nome para validar e definir o valor
            Sobrenome = sobrenome; // Usa a propriedade Sobrenome para validar e definir o valor
            Idade = idade; // Usa a propriedade Idade para validar e definir o valor
        }

        public string Nome 
        { 
            get => _nome.ToUpper(); 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            }
        }

        public string Sobrenome 
        { 
            get => _sobrenome.ToUpper(); 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio.");
                }
                _sobrenome = value;
            }
        }

        public int Idade 
        { 
            get => _idade; 
            set {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor do que zero.");
                }
                _idade = value;
            } 
        }

        public void Apresentar() 
        {
            Console.WriteLine($"Nome Completo: {Nome} {Sobrenome}, Idade: {Idade}");
        }
    }
}
