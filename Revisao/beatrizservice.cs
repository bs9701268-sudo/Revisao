
using System;
using System.Collections.Generic;

namespace Revisao
{
    class beatrizservice
    {
        public int Id;
        public List<string> Beatriz = new List<string>();
        public string Apelido;
        public int Idade;
        public string Sexo;
        public List<string> Habilidade = new List<string>();

        public void ExibirDados()
        {
            Console.WriteLine("===== MEUS DADOS =====");
            Console.WriteLine($"Meu ID é: {Id}");
            Console.WriteLine($"Meu apelido é: {Apelido}");
            Console.WriteLine($"Minha idade é: {Idade}");
            Console.WriteLine($"Meu sexo é: {Sexo}");

            Console.WriteLine("Meu nome é:");
            foreach (string aluno in Beatriz)
            {
                Console.WriteLine($"- {aluno}");
            }

            Console.WriteLine("Minhas habilidades são:");
            foreach (string habilidade in Habilidade)
            {
                Console.WriteLine($"- {habilidade}");
            }
        }
    }
}
