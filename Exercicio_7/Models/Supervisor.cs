namespace Exercicio_7.Models
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario, int grauInstrucao)
            : base(nome, idade, salario, grauInstrucao)
        {
        }

        public override double Bonificacao()
        {
            return (Salario + 5000.00);
        }

    }
}
