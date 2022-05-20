namespace Exercicio_7.Models
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario, int grauInstrucao)
            : base(nome, idade, salario, grauInstrucao)
        {
        }

        public override double Bonificacao()
        {
            return (Salario + 3000.00);
        }

    }
}
