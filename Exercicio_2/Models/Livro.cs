using System;

namespace Exercicio_2.Models
{
    public class Livro : Produto, IImposto
    {
        public Livro(string nome, double preço, int quantidade, string autor, string tema, int qntPaginas) 
            :base( nome,  preço,  quantidade)
        {
            Autor = autor;
            Tema = tema;
            QntPaginas = qntPaginas;
        }

        public string Autor { get; private set; }
        public string Tema { get; private set; }
        public int QntPaginas { get; private set; }

        public double CalcularImposto()
        {
            if (Tema.Contains("educativo"))
            {
                return 0;
            }

            var calcImposto = Preco * 0.10;
            return calcImposto;
        }

        public override string ToString()
        {
            return $"Titulo: {Nome}, Preço:{Preco:F1}, Qauntidade: {Quantidade} em estoque.";
        }
    }
}
