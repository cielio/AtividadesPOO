namespace Exercicio_7.Models
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double Salario { get; private set; }
        public Funcionario(string nome, int idade, double salario, int grauInstrucao)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }


        public virtual double Bonificacao()
        {
            return Salario;
        }

    }
}
