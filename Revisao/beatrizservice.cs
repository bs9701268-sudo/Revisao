
using System;
using Revisao;

int opcao = -1;

while (opcao != 0)
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1 - Adicionar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Escolha uma opção:");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Digite um número válido!");
        opcao = -1;
        continue;
    }

    switch (opcao)
    {
        case 1:
            beatrizservice.Adicionar();
            break;

        case 2:
            beatrizservice.Listar();
            break;

        case 0:
            Console.WriteLine("Programa encerrado!");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}
