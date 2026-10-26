namespace Nomes
{

    public class Beatriz
    {
        public int Id; 

        public string Nome;

        public string Apelido;

        public int Idade;

        public string Sexo;

        public List<string> Gostos;

        public void ExibirDados()
        {
            Console.WriteLine($"meu nome é {Nome}");

            foreach (char nome in Nome)
            {
                Console.WriteLine($" - {Nome}");
            }
        }
    }
}

