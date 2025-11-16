using System;

namespace POO_Interfaces_Pagamentos
{
    internal class PagamentoCartao : IPagamento
    {
        public void Pagar()
        {
            Console.WriteLine("Pagamento com cartão realizado com sucesso!");
        }

        public void Cancelar()
        {
            Console.WriteLine("Pagamento com cartão cancelado!");
        }
    }
}
