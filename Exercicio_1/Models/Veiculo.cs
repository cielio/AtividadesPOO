namespace Exercicio_1.Models
{
    public class Veiculo
    {
        public Veiculo(string marca, string modelo, string placa, string cor, float km, double preco)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Km = km;
            Preco = preco;
        }

        public string Modelo { get; private set; }
        public string Marca { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public float Km { get; private set; }
        public bool IsLigado { get; private set; }
        public int LitrosCombustivel { get; private set; }
        public int Velocidade { get; private set; }
        public double Preco { get; private set; }

        public void Acelerar()
        {
            Velocidade += 20;
        }

        public void Abastecer(int combustivel)
        {
            if ((LitrosCombustivel + combustivel) < 60)
            {
                LitrosCombustivel += combustivel;
            }
        }

        public void Frear()
        {
            if (Velocidade > 0)
            {
                Velocidade -= 20;
            }
        }

        public void Pintar(string cor)
        {
            Cor = cor;
        }

        public void Ligar()
        {
            if (!IsLigado)
            {
                IsLigado = true;
            }else
            {
                System.Console.WriteLine("O carro Ja esta lisgado");
            }
        }

        public void Desligar()
        {
            if (IsLigado)
            {
                IsLigado = false;
            }else{
                System.Console.WriteLine("O carro Ja esta delisgado");
            }
        }

        public override string ToString()
        {
            return $"\nModelo: {Modelo}, Marca: {Marca}, Placa: {Placa}, Cor: {Cor},\nKM: {Km}, {(IsLigado ? "Ligado":"Desligado")}, Litros Cobustibel: {LitrosCombustivel}, Velocidade: {Velocidade}, Preço: {Preco}";
        }
    }
}