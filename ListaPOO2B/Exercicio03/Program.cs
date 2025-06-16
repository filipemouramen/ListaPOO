using Exercicio03;

LojaVirtual _lojaVirtual = new LojaVirtual();

Console.WriteLine("Selecione o método de pagamento:");
Console.WriteLine("1 - Cartão de Crédito");
Console.WriteLine("2 - Boleto");
Console.WriteLine();

int opcao = int.Parse(Console.ReadLine());

IPagamento pagamento;

switch (opcao)
{
    case 1:
        pagamento = new PagamentoCartaoCredito();
        break;
    case 2:
        pagamento = new PagamentoBoleto();
        break;
    default:
        Console.WriteLine("Opção inválida.");
        return;
}

Console.WriteLine("Digite o valor do pagamento:");
decimal valor = decimal.Parse(Console.ReadLine());
_lojaVirtual.RealizarPagamento(pagamento, valor);   