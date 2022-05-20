namespace Exercicio_7.Models
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario, int grauInstrucao)
            : base(nome, idade, salario, grauInstrucao)
        {
        }

        public override double Bonificacao()
        {
            return (Salario + 10000.00);
        }

    }
}
