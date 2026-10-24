

using Revisao.service;
BeatrizRepository.Inicializar();

int opcao = 0;

while (opcao != -1)
{
    Console.WriteLine("\n===== MEUS DADOS =====");
    Console.WriteLine("1 - Adicionar meus dados");
    Console.WriteLine("2 - Listar meus dados");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Digite a opção desejada:");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Digite uma opção válida!");
        continue;
    }

    if (opcao == 1)
    {
        BeatrizService.Adicionar();
    }
    else if (opcao == 2)
    {
        BeatrizService.Listar();
    }
    else if (opcao == 0)
    {
        opcao = -1;
        Console.WriteLine("Sistema encerrado!");
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Infraestrutura
{
    class beatrizreposity
    {
    }
}
