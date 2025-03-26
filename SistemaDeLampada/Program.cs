using SistemaDeLampada;

Lampada _lampada = new Lampada();

string opcao = " ";

while (opcao != "4")
{
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine();
    Console.WriteLine("Digite 1 para ligar a lâmpada.");
    Console.WriteLine("Digite 2 para desligar a lâmpada.");
    Console.WriteLine("Digite 3 para mostrar o estado atual da lâmpada.");
    Console.WriteLine("Digite 4 para sair.");
    Console.WriteLine();

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            _lampada.Ligar();
            _lampada.MostrarEstado();
            break;
            case "2":
            _lampada.Desligar();
            _lampada.MostrarEstado();
            break;
            case "3":
            _lampada.MostrarEstado();
            break;
            case "4":
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida. Digite um numero de 1 a 4.");
            break;
    }
}