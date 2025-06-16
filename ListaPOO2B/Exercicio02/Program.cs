using Exercicio02;

List<Produto> produtos = new List<Produto>();

Produto _produto = new Produto();

while (true)
{
    _produto.MostrarMenu();
    Console.WriteLine();

    Console.WriteLine("Digite a opção desejada: ");
    string input = Console.ReadLine();
    int opcao;

    if (!int.TryParse(input, out opcao))
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
        continue;
    }

    switch (opcao)
    {
        case 1:
            Console.Clear();
            Produto produto = new Produto();
            produto.CadastrarProduto(produtos);
            break;
        case 2:
            Console.Clear();
            Produto listarProduto = new Produto();
            listarProduto.ListarProdutos(produtos);
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            Console.Clear();
            Produto removerProduto = new Produto();
            removerProduto.RemoverProduto(produtos);
            Console.Clear();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 4:
            Produto menorValor = new Produto();
            menorValor.ListarProdutoMenorValor(produtos);
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 5:
            Produto maiorValor = new Produto();
            maiorValor.ListarProdutoMaiorValor(produtos);
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 6:
            Console.WriteLine("Saindo do programa...");
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}