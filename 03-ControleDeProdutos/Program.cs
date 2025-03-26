using _03_ControleDeProdutos;

Produto _produto = new Produto();

Console.WriteLine("Digite a quantidade de produtos que irá cadastrar no sistema de estoque:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

Produto[] vetor = new Produto[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Digite os dados do {i + 1}º produto, para realizar o cadastro");
   
    Console.Write("Nome do produto:");
    string nome = Console.ReadLine();
   

    Console.Write($"Digite o preço do(a) {nome}:");
    double preco = double.Parse(Console.ReadLine());
  

    Produto CadastroProduto = new Produto { Nome = nome, Preco = (decimal)preco };

    Console.Write($"Digite a quantidade de {nome} que irá ser adicionado no estoque:");
    CadastroProduto.AdicionarEstoque(int.Parse(Console.ReadLine()));

   

    vetor[i] = CadastroProduto;
}

Console.Clear();

for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    Console.WriteLine("Dados do produto:");
    vetor[i].DetalhesProdutos();
    Console.WriteLine();
}

bool Remocao = true;

while (Remocao)
{
    Console.WriteLine("Gostaria de retirar algum produto do estoque? Digite SIM ou NAO");
    string RemocaoProduto = Console.ReadLine().ToUpper();

    if (RemocaoProduto == "SIM")
    {
        Console.WriteLine("Digite o nome do produto a ser removido:");
        string nomeProduto = Console.ReadLine().ToUpper();
        bool ProdutoEncontrado = false;

        for (int i = 0; i < n; i++)
        {
            if (vetor[i].Nome.ToUpper() == nomeProduto)
            {
                ProdutoEncontrado = true;
                Console.WriteLine($"Digite a quantidade de {vetor[i].Nome} a ser removida:");
                int quantidade = int.Parse(Console.ReadLine());
                vetor[i].RemoverEstoque(quantidade);
                Console.Clear();

                Console.WriteLine("Estoque atuaizado: ");
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine();
                    vetor[j].DetalhesProdutos();
                    Console.WriteLine();
                }
            }
        }

        if (!ProdutoEncontrado)
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }
    else if (RemocaoProduto == "NAO")
    {
        Console.Clear();
        Console.WriteLine("Dados do estoque:");
        for (int i = 0; i < n; i++)
        {
            vetor[i].DetalhesProdutos();
            Remocao = false;
        }
    }
    else
    {
        Console.WriteLine("Opção inválida. Digite SIM ou NAO.");
    }
}