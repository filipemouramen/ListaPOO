using Exercicio01;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>();

        while (true)
        {
            Console.WriteLine("O que deseja fazer hoje? Digite uma das opções abaixo:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Cadastrar aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Alterar dados de um aluno");
            Console.WriteLine("4 - Remover aluno");
            Console.WriteLine("5 - Sair do programa");
            Console.WriteLine("-------------------------------");

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
                    Aluno.CadastrarAluno(alunos);

                    break;
                case 2:
                    Console.Clear();
                    Aluno.ListarAlunos(alunos);
                    break;
                case 3:
                    Console.Clear();
                    Aluno.AlterarDados(alunos);
                    break;
                case 4:
                    Console.Clear();
                    Aluno.RemoverAluno(alunos);
                    break;
                case 5:
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.\n");
                    break;
            }
        }
    }
}
