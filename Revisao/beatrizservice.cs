
using System;
using System.Collections.Generic;
using System.Linq;

namespace Revisao
{
    public static class beatrizService
    {
        public static List<beatriz> BancoDados = new List<Prova>()
        {
            new Prova()
            {
                Id = 1,
                Disciplina = "Beatriz Silva",
                Nota = 10,
                Questoes = new List<string>()
                {
                    "Qual é meu apelido?",
                    "O que gosto de fazer?",
                    "Qual linguagem estou aprendendo?"
                },
                Gabarito = new List<char>()
                {
                    'A',
                    'B',
                    'C'
                }
            }
        };

        public static void Adicionar()
        {
            Prova prova = new Prova();

            prova.Questoes = new List<string>();
            prova.Gabarito = new List<char>();

            prova.Id = BancoDados.Count > 0
                ? BancoDados.Max(p => p.Id) + 1
                : 1;

            Console.WriteLine("Digite seu nome:");
            prova.Disciplina = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            prova.Nota = int.Parse(Console.ReadLine());

            Console.WriteLine("Deseja adicionar mais questões? Digite sim ou nao:");
            string resposta = Console.ReadLine();

            while (resposta.ToLower() == "sim")
            {
                Console.WriteLine("Digite uma pergunta sobre você:");
                prova.Questoes.Add(Console.ReadLine());

                Console.WriteLine("Deseja adicionar mais questões? Digite sim ou nao:");
                resposta = Console.ReadLine();
            }

            Console.WriteLine("Deseja adicionar o gabarito? Digite sim ou nao:");
            resposta = Console.ReadLine();

            while (resposta.ToLower() == "sim")
            {
                Console.WriteLine("Digite uma resposta (uma letra):");
                prova.Gabarito.Add(char.Parse(Console.ReadLine()));

                Console.WriteLine("Deseja adicionar mais respostas? Digite sim ou nao:");
                resposta = Console.ReadLine();
            }

            BancoDados.Add(prova);

            Console.WriteLine("Dados cadastrados com sucesso!");
        }

        public static void ListarProvas()
        {
            foreach (Prova item in BancoDados)
            {
                item.ExibirDados();
            }
        }
    }
}
