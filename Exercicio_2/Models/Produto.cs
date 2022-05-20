namespace Exercicio_2.Models
{
    public abstract class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        protected Produto() { }

        protected Produto(string nome, double preço, int quantidade)
        {
            Nome = nome;
            Preco = preço;
            Quantidade = quantidade;
        }
    }
}
