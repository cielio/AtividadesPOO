using System;
using System.Collections.Generic;
using Exercicio_2.Models;

namespace Exercicio_2.Models
{
    public class Loja
    {
        public string Nome { get; private set; }
        public string Cnpj { get; private set; }
        public List<Livro> Livros { get; private set; }
        public List<VideoGame> VideoGames { get; private set; }
        public Loja() { }
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            Livros = livros;
            VideoGames = videoGames;
        }

        public void ListaLivros()
        {
            if (Livros.Count > 0)
            {
                Livros.ForEach(livro => Console.WriteLine(livro));
            }
            else
            {
                Console.WriteLine("A loja não tem livros no seu estoque.");
            }
        }

        public void ListaVideoGames()
        {
            if (VideoGames.Count > 0)
            {
                VideoGames.ForEach(videoGame => Console.WriteLine(videoGame));
            }
            else
            {
                Console.WriteLine("A loja não tem video-games no seu estoque.");
            }
        }

        public double CalcularPatripomino()
        {
            double patrimonio = 0;
            Livros.ForEach(livro => patrimonio += livro.Preco * livro.Quantidade);
            VideoGames.ForEach(videoGame => patrimonio += videoGame.Preco * videoGame.Quantidade);

            return patrimonio;
        }
    }
}
