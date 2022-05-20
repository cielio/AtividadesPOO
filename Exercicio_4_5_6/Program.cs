using System;
using System.Collections.Generic;
using System.Linq;
using Exercicio_4_5_6.Models;

namespace Exercicio_4_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoa = new List<Pessoa>
            {
                new Pessoa(nome: "Joao",    idade: 15),
                new Pessoa(nome: "Leandro", idade: 21),
                new Pessoa(nome: "Paulo",   idade: 17),
                new Pessoa(nome: "Jessica", idade: 18)
            };
            MostrarTodosDalista(listaPessoa);

            //Exercício 4
            Console.WriteLine("\nExercício 4 - Pessoa Mais velha");
            var pessoaMaisVelha = listaPessoa.OrderBy(pessoa => pessoa.Idade).First();
            Console.WriteLine(pessoaMaisVelha);

            //Exercício 5
            Console.WriteLine("\nExercício 5 - Remover menores de 18 anos");

            Console.WriteLine($"Total de pessoas na lista: {listaPessoa.Count}");
            listaPessoa.RemoveAll(pessoa => pessoa.Idade < 18);
            Console.WriteLine($"Total de pessoas na lista: {listaPessoa.Count}");

            //Exercício 6
            Console.WriteLine("\nExercício 6 - verificar e mostrar a idade da Jessica");

            var pessoa = listaPessoa.Where(pessoa => pessoa.Nome == "Jessica").FirstOrDefault();
            if (pessoa != null)
            {
                Console.WriteLine($"A idade de {pessoa.Nome} é {pessoa.Idade}");
            }
            Console.WriteLine();

            //Mostrar Todas as pessoas da Lista
            MostrarTodosDalista(listaPessoa);
        }

        private static void MostrarTodosDalista(IEnumerable<Pessoa> pessoas)
        {
            Console.WriteLine("Mostrar Todas as pessoas da Lista");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
