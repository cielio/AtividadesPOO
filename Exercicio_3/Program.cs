using System;
using Exercicio_3.Moldels;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var guerreiro = new Guerreiro("Joao", 200, 20, 0, 20, 50, 1);
            var mago = new Mago("Luz", 150, 50, 0, 50, 20, 1);
            
            guerreiro.Habilidades.Add("Golpe Da Morte");
            guerreiro.Habilidades.Add("Machado");
            mago.Magias.Add("Bola de fogo");
            mago.Magias.Add("Raio Verde");

            Console.WriteLine();
            
            Console.WriteLine($"Quantidade de Personagens Criados: {Personagem.QuntPersonagens}");
            guerreiro.LevelUp();
            Console.WriteLine(guerreiro);

            Console.WriteLine();

            mago.LevelUp();
            Console.WriteLine(mago);
        }
    }
}
