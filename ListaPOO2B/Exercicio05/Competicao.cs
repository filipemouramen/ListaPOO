using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class Competidor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Modalidade { get; set; }
    }

    public class Competicao
    {
        public string Nome { get; set; }

        public void AdicionarCompeticao()
        {
            Console.WriteLine("Digite o nome da competição a ser adicionada:");
            Nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Nome))
            {
                Console.WriteLine();
                throw new ArgumentException("O nome da competição não pode ser vazio");
            }
            Console.WriteLine();
            Console.WriteLine($"Competição {Nome} adicionada com sucesso!");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");  
            Console.ReadKey();
        }

        public List<Competidor> Competidores { get; set; } = new List<Competidor>();

        public void AdicionarCompetidor(Competidor _competidor)
        {
            Console.WriteLine("Digite o nome do competidor a ser adicionado:");
            _competidor.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do competidor:");

            try
            {
                _competidor.Idade = int.Parse(Console.ReadLine());

                if (_competidor.Idade < 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa");
                }
            }
            catch
            {
                Console.WriteLine("Erro: Idade inválida. Por favor, insira um número inteiro positivo.");
                return;
            }

            Console.WriteLine("Digite a modalidade do competidor:");
            _competidor.Modalidade = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Competidor: {_competidor.Nome} | Idade: {_competidor.Idade} | Modalidade: {_competidor.Modalidade} | adicionado");

            Competidores.Add(_competidor);
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ListarCompetidores()
        {
            if (Competidores.Count == 0)
            {
                Console.WriteLine("Nenhum competidor foi cadastrado!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Lista de competidores:");

                foreach (var competidor in Competidores)
                {
                    Console.WriteLine($"Nome: {competidor.Nome}, Idade: {competidor.Idade}, Modalidade: {competidor.Modalidade}");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}