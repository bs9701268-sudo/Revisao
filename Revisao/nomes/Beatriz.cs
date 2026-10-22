namespace Nomes
{

    public class Beatriz
    {

        public string Nome;

        public int Idade;

        public List<string> Habilidades;

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

