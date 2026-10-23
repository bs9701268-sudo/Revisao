
using Revisao;

beatrizservice beatriz = new beatrizservice();

beatriz.Id = 1;
beatriz.Apelido = "Bea e Bia";
beatriz.Idade = 17;
beatriz.Sexo = "Feminino";

beatriz.Beatriz.Add("Beatriz");
beatriz.Beatriz.Add("Beatriz Steffany");

beatriz.Habilidade.Add("Ouvir música");
beatriz.Habilidade.Add("Assistir séries");
beatriz.Habilidade.Add("Sair com amigos");

int opcao = 0;

while (opcao != -1)
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1 - Adicionar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Escolha uma opção:");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Digite um número válido!");
        opcao = 0;
        continue;
    }

    if (opcao == 1)
    {
        Console.WriteLine("Digite um novo nome:");
        string nome = Console.ReadLine();
        beatriz.Beatriz.Add(nome);

        Console.WriteLine("Digite uma nova habilidade:");
        string habilidade = Console.ReadLine();
        beatriz.Habilidade.Add(habilidade);

        Console.WriteLine("Dados adicionados com sucesso!");
    }
    else if (opcao == 2)
    {
        beatriz.ExibirDados();
    }
    else if (opcao == 0)
    {
        opcao = -1;
        Console.WriteLine("Programa encerrado!");
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}
