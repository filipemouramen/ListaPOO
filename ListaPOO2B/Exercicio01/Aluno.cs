using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio01
{
    class Aluno
    {
        public int RA { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public static void CadastrarAluno(List<Aluno> alunosListados)
        {
            Aluno novoAluno = new Aluno();
            Console.WriteLine("Digite o RA do aluno:");
            novoAluno.RA = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do aluno, com RA n.º {novoAluno.RA}:");
            novoAluno.Nome = Console.ReadLine();

            Console.WriteLine($"Digite a idade do {novoAluno.Nome}:");
            novoAluno.Idade = int.Parse(Console.ReadLine());

            alunosListados.Add(novoAluno);
            Console.WriteLine();
            Console.WriteLine("Aluno cadastrado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ListarAlunos(List<Aluno> alunosListados)
        {
            if (alunosListados.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.WriteLine("Lista de Alunos:");
            Console.WriteLine("-------------------------------");
            foreach (var aluno in alunosListados)
            {
                Console.WriteLine($"RA: {aluno.RA}, Nome: {aluno.Nome}, Idade: {aluno.Idade} anos");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void AlterarDados(List<Aluno> alunosListados)
        {
            Console.WriteLine("Digite o RA do aluno a alterar os dados:");
            int ra = int.Parse(Console.ReadLine());

            var aluno = alunosListados.FirstOrDefault(a => a.RA == ra);

            if (aluno != null)
            {
                Console.WriteLine($"Digite o novo nome do aluno com RA {ra}:");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine($"Digite a nova idade do aluno com RA {ra}:");
                aluno.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Dados alterados com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void RemoverAluno(List<Aluno> alunosListados)
        {
            Console.WriteLine("Digite o RA do aluno a ser removido:");
            int ra = int.Parse(Console.ReadLine());

            var aluno = alunosListados.FirstOrDefault(a => a.RA == ra);
            if (aluno != null)
            {
                alunosListados.Remove(aluno);
                Console.WriteLine($"Aluno com RA {ra} removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}