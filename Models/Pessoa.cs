using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_explorando_c_sharpe.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar() {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}