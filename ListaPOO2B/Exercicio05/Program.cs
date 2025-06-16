using Exercicio05;

Competicao _competicao = new Competicao();

while (true)
{
    Console.WriteLine("Bem vindo! O que deseja fazer hoje?");
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar nova competição");
    Console.WriteLine("2 - Adicionar competidores");
    Console.WriteLine("3 - Listar competidores");
    Console.WriteLine("4 - Sair");
    Console.WriteLine();
    Console.WriteLine("Digite a opção desejada: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();
            _competicao.AdicionarCompeticao();
            break;
        case "2":
            Console.Clear();
            _competicao.AdicionarCompetidor(new Competidor());
            break;
        case "3":
            Console.Clear();
            _competicao.ListarCompetidores();
            break;
        case "4":
            Console.WriteLine("Saindo do programa...");
            return;
        default:
            Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");
            break;
    }
}