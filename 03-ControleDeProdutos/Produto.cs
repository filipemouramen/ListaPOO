using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _03_ControleDeProdutos
{
    class Produto
    {
        public string Nome;
        public decimal Preco;
        public int Quantidade;

        public void AdicionarEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public void DetalhesProdutos()
        {
            Console.WriteLine(Nome);
            Console.WriteLine($"Valor unitário: R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quantidade: {Quantidade} unidades");
        }
    }
}