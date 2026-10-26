
using Nomes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Revisao.service
{
    public static class brendaservice
    {
        public static List<Brenda> BancoDados = new List<Brenda>()
        {
           
        };

        public static void Adicionar()
        {
            Brenda pessoa = new Brenda();

            pessoa.Id = BancoDados.Count > 0
                ? BancoDados.Max(p => p.Id) + 1
                : 1;

            Console.WriteLine("Digite seu nome:");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu apelido:");
            pessoa.Apelido = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu sexo:");
            pessoa.Sexo = Console.ReadLine();

            pessoa.Gostos = new List<string>();

            Console.WriteLine("Deseja adicionar algo de que gosta? Digite sim ou nao:");
            string resposta = Console.ReadLine();

            while (resposta.ToLower() == "sim")
            {
                Console.WriteLine("Digite algo de que você gosta:");
                pessoa.Gostos.Add(Console.ReadLine());

                Console.WriteLine("Deseja adicionar mais alguma coisa? Digite sim ou nao:");
                resposta = Console.ReadLine();
            }

            BancoDados.Add(pessoa);

            Console.WriteLine("Dados cadastrados com sucesso!");
        }

        public static void Listar()
        {
            foreach (Brenda item in BancoDados)
            {
                item.ExibirDados();
            }
        }
    }
}
