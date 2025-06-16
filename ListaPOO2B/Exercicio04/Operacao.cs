using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Operacao
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public void Divisao()
        {
            try
            {
                Console.WriteLine("Digite o primeiro número:");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                num2 = int.Parse(Console.ReadLine());

                if (num2 == 0)
                {
                    throw new DivideByZeroException("Não é possível dividir por zero!");
                }

                int resultado = num1 / num2;
                Console.WriteLine($"Resultado da divisão é {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Erro: Você só pode digitar números inteiros!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("Erro: Não é possível dividir por zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Erro inesperado: Robinho pague o pastel!");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Operação finalizada!");
            }

            Console.WriteLine();
            Console.WriteLine("Deseja realizar outra divisão? (s/n)");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "s")
            {
                Console.WriteLine();
                Divisao();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Obrigado por utilizar o programa!");
            }
        }
    }
}