
using Nomes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Revisao.service
{
    public static class BeatrizService
    {
        public static List<Beatriz> BancoDados = new List<Beatriz>()
        {
            new Beatriz()
            {
               Id = 1,
               Nome = "Beatriz Steffany",
               Apelido = "Bea e Bia",
               Idade = 18,
               Sexo = "Feminino",
               Gostos = new List<string>()
                {
                    "Ouvir música",
                    "Assistir séries",
                    "Sair com amigos"
                }
            }
        };

        public static void Adicionar()
        {
            Beatriz pessoa = new Beatriz();

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
            foreach (Beatriz item in BancoDados)
            {
                item.ExibirDados();
            }
        }
    }
}
