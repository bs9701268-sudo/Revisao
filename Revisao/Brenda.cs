using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Brenda
    {
        public string Nome;
        public int Idade;
        public List<string> Hablidades;
        public void ExibirDados()
        {
            Console.WriteLine($"Meu nome é{Nome}");
            foreach(char nome2 in Nome)
            {
                Console.WriteLine($" - {Nome}");
            }
        }
    }
}
