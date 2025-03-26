using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoNota
{
    class Aluno
    {
        public string AlunoName;
        public double AlunoRA;
        public double NotaProva;
        public double NotaTrabalho;
        public double NotaFinal;

        public void CalcularMedia()
        {
            NotaFinal = (NotaProva + NotaTrabalho) / 2;
        }

        public void CalcularNotaFinal()
        {
            if (NotaFinal >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Aprovado!");
            }
            else
            {
                double NotaRecuperacao = 12 - (NotaFinal / 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Reprovado! Você precisa tirar {NotaRecuperacao.ToString("F2")} pontos!");
                Console.ResetColor();
            }
        }

        public void ImprimirNota()
        {
          Console.WriteLine();
          Console.WriteLine($"A média do(a) {AlunoName} é {NotaFinal.ToString("F2")} ");
        }

        public void ReceberDados()
        {
            Console.WriteLine("Digite o nome completo do(a) Aluno:");
            AlunoName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Digite o RA do(a) {AlunoName}");
            AlunoRA = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a nota da prova:");
            NotaProva = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a nota do trabalho:");
            NotaTrabalho = double.Parse(Console.ReadLine());
            Console.WriteLine();

        }
    }
}