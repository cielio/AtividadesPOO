using System;
using System.Linq;
using System.Collections.Generic;
using Exercicio_2.Models;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            Livro livro2 = new Livro("Senhor dos Aneis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro livro3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(livro1);
            livros.Add(livro2);
            livros.Add(livro3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            Loja americanas = new Loja("Americanas", "12345678", livros, games);

            Console.WriteLine($"Livro educativo nao tem imposto: {livro2.Nome}");

            ImprimirImpostoLivro(livro2);
            ImprimirImpostoLivro(livro3);

            ImprimirImpostoVideoGame(ps4Usado);
            ImprimirImpostoVideoGame(ps4);

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"A loja {americanas.Nome} possui estes Livors para vender:");
            americanas.ListaLivros();

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"A loja {americanas.Nome} possui estes Video-games para vender:");
            americanas.ListaVideoGames();

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"O patrimonio da loja: {americanas.Nome} é de R$ {americanas.CalcularPatripomino():F1}");


    
        }

        private static void ImprimirImpostoLivro(Livro livro)
        {
            if (livro.CalcularImposto() == 0)
            {
                Console.WriteLine($"Livro educativo nao tem imposto: {livro.Nome}");
            }
            else
            {
                Console.WriteLine($"R$ {livro.CalcularImposto():F1} de imposto sobre o livro {livro.Nome}");
            }
        }

        private static void ImprimirImpostoVideoGame(VideoGame videoGame)
        {
            if (videoGame.IsUsado)
            {
                Console.WriteLine($"Imposto {videoGame.Nome} usado, R$ {videoGame.CalcularImposto():F1}");
            }
            else
            {
                Console.WriteLine($"Imposto {videoGame.Nome}, R$ {videoGame.CalcularImposto():F1}");
            }
        }
    }
}
