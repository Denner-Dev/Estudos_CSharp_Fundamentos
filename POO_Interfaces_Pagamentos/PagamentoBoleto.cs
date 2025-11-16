using System;

namespace POO_Interfaces_Pagamentos
{
    internal class PagamentoBoleto : IPagamento
    {
        public void Pagar()
        {
            Console.WriteLine("Pagamento com boleto realizado com sucesso!");
        }

        public void Cancelar()
        {
            Console.WriteLine("Pagamento com boleto cancelado!");
        }
    }
}
