using System;
using System.Collections.Generic;

namespace exemplo_explorando_c_sharpe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de código
            Queue<int> fila = new Queue<int>();

            fila.Enqueue(10);
            fila.Enqueue(20);
            fila.Enqueue(30);

            while (fila.Count > 0)
            {
                int item = fila.Dequeue();
                Console.WriteLine($"Elemento removido: {item}");
            }

            fila.Enqueue(40);
            fila.Enqueue(50);

            Console.WriteLine($"Elemento no início da fila: {fila.Peek()}");
            Console.WriteLine($"Elemento removido: {fila.Dequeue()}");
        }
    }
}
