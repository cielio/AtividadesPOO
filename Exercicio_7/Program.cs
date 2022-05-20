using Exercicio_7.Models;
using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Cielio", 25, 4000.00, 5);
            Supervisor supervisor = new Supervisor("Rafael", 45, 2000.00, 3);
            Vendedor vendedor = new Vendedor("Joao", 27, 1500.00, 2);

            Console.WriteLine($"Gerente {gerente.Bonificacao():C}");
            Console.WriteLine($"Supervisor {supervisor.Bonificacao():C}");
            Console.WriteLine($"Vendedor {vendedor.Bonificacao():C}");
        }
    }
}
