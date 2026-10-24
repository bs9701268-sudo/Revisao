
using System;
using System.Collections.Generic;

namespace Revisao
{
    public class Prova
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Apelido { get; set; }
        public string Sexo { get; set; }

        public List<string> Beatriz { get; set; }
            = new List<string>();

        public List<string> Habilidade { get; set; }
            = new List<string>();

        public void ExibirDados()
        {
            Console.WriteLine("\n===== MEUS DADOS =====");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Apelido: {Apelido}");
            Console.WriteLine($"Sexo: {Sexo}");

            Console.WriteLine("\nNomes:");

            foreach (string nome in Beatriz)
            {
                Console.WriteLine($"- {nome}");
            }

            Console.WriteLine("\nHabilidades:");

            foreach (string habilidade in Habilidade)
            {
                Console.WriteLine($"- {habilidade}");
            }
        }
    }
}
