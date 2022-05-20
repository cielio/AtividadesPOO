namespace Exercicio_2.Models
{
    public class VideoGame : Produto, IImposto
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public bool IsUsado { get; private set; }

        public VideoGame() { }

        public VideoGame(string nome, double preço, int quantidade,
                         string marca, string modelo, bool isUsuario)
            : base(nome, preço, quantidade)
        {
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsuario;
        }

        public double CalcularImposto()
        {
            double calcImposto ;

            if (IsUsado)
            {
                calcImposto = Preco * 0.25;
                return calcImposto;
            }

            calcImposto = Preco * 0.45;
            return calcImposto;
        }

        public override string ToString()
        {
            return $"Video-game: {Nome}, Preço: {Preco:F1}, Qauntidade: {Quantidade} em estoque.";
        }
    }
}
