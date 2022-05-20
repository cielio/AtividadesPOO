using System;
using Exercicio_1.Models;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("Ferrari", "Portofino", "ABC2323", "Preto", 0.0F, 1000000.0);
            veiculo.Abastecer(20);
            Console.WriteLine(veiculo);

            veiculo.Ligar();
            veiculo.Acelerar();
            Console.WriteLine(veiculo);

            veiculo.Frear();
            veiculo.Desligar();
            Console.WriteLine(veiculo);
        }
    }
}
