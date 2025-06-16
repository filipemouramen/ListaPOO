using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public interface IPagamento
    {
        void ProcessarPagamento(decimal valor);
    }

    public class PagamentoCartaoCredito : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de {valor.ToString("F2")} processado via Cartão de Crédito.");
        }
    }
    public class PagamentoBoleto : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de {valor.ToString("F2")} processado via Boleto.");

        }
    }

    public class LojaVirtual
    {
        public void RealizarPagamento(IPagamento _pagamento, decimal valor)
        {
            _pagamento.ProcessarPagamento(valor);
        }
    }
}