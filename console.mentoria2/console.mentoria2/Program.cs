using console.mentoria2;

bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("=== Menu de Exemplos ===");
    Console.WriteLine("1 - Exemplo Tratamento Error");
    Console.WriteLine("2 - Exemplo Número Inteiro");
    Console.WriteLine("3 - Exemplo Número Decimal");
    Console.WriteLine("4 - Exemplo com Boleano");
    Console.WriteLine("5 - Exemplo com String");
    Console.WriteLine("0 - Sair");
    Console.Write("\nEscolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            ExemploError.Executar();
            break;
        case "2":
            ExemploInteiro.Executar();
            break;
        case "3":
            ExemploDecimal.Executar();
            break;
        case "4":
            ExemploBoleano.Executar();
            break;
        case "5":
            ExemploString.Executar();
            break;
        case "0":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    if (continuar)
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}