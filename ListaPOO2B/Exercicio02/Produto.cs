using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Produto
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public void MostrarMenu()
        {
            Console.WriteLine("O que deseja fazer hoje?");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("3 - Remover produto");
            Console.WriteLine("4 - Exibir produto com menor valor");
            Console.WriteLine("5 - Exibir produto com maior valor");
            Console.WriteLine("6 - Pesquisar produto");
            Console.WriteLine("7 - Sair do programa");
            Console.WriteLine("-------------------------------");
        }


        public void CadastrarProduto(List<Produto> produtosListados)
        {
            Produto _produto = new Produto();

            Console.WriteLine("Digite o nome do produto:");
            _produto.Descricao = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Digite o valor do produto {_produto.Descricao}:");

            double valor;

            while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.WriteLine("Valor inválido. Por favor, digite um valor positivo.");
            }

            _produto.Valor = valor;

            produtosListados.Add(_produto);

            Console.WriteLine();
            Console.WriteLine("Produto cadastrado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ListarProdutos(List<Produto> produtosListados)
        {
            if (produtosListados.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }
            else
            {
                Console.WriteLine("Lista de Produtos:");
                Console.WriteLine("-------------------------------");
                foreach (var produto in produtosListados)
                {
                    Console.WriteLine($"Descrição: {produto.Descricao}, Valor: R$ {produto.Valor:F2}");
                }
                Console.WriteLine("-------------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public void RemoverProduto(List<Produto> produtosListados)
        {
            Console.WriteLine("Digite o nome do produto a ser removido:");
            string descricao = Console.ReadLine();

            var produto = produtosListados.FirstOrDefault(p => p.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
            
            if (produto != null)
            {
                produtosListados.Remove(produto);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
            Console.WriteLine();
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public void PesquisarProduto(List<Produto> produtosListados)
        {
            Console.WriteLine("Digite o nome do produto a ser pesquisado:");
            string descricao = Console.ReadLine();

            var produto = produtosListados.FirstOrDefault(p => p.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
           
            if (produto != null)
            {
                Console.WriteLine($"Produto encontrado: Descrição: {produto.Descricao}, Valor: R$ {produto.Valor:F2}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
            Console.WriteLine();
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ListarProdutoMaiorValor(List<Produto> produtosListados)
        {
            if (produtosListados == null || produtosListados.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }
            var maiorProduto = produtosListados.OrderByDescending(p => p.Valor).First();
            Console.WriteLine($"Produto com maior valor: Descrição: {maiorProduto.Descricao}, Valor: R$ {maiorProduto.Valor:F2}");
        }

        public void ListarProdutoMenorValor(List<Produto> produtosListados)
        {
            if (produtosListados == null || produtosListados.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            var menorProduto = produtosListados.OrderBy(p => p.Valor).First();

            Console.WriteLine($"Produto com menor valor: Descrição: {menorProduto.Descricao}, Valor: R$ {menorProduto.Valor:F2}");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
