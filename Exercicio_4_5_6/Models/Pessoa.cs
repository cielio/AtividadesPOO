using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4_5_6.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            DateTime = DateTime.Now;
        }

        public string Nome { get; }
        public int Idade { get; }

        public DateTime DateTime { get; }
        
        public override string ToString()
        {
            return $"Nome: {Nome} Idade: {Idade} Data: {DateTime.ToShortDateString()}";
        }
    }
}
