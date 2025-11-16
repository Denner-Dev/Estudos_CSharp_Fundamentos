using System;

namespace POO_Interfaces_Pagamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPagamento pagamentoCartao = new PagamentoCartao();
            IPagamento pagamentoBoleto = new PagamentoBoleto();

            pagamentoCartao.Pagar();
            pagamentoBoleto.Pagar();

            pagamentoCartao.Cancelar();
            pagamentoBoleto.Cancelar();
        }
    }
}
