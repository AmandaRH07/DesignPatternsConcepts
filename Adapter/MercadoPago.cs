using Adapter.Interfaces;
using System;

namespace Adapter
{
    public class MercadoPago : IMercadoPagoPayments
    {
        private Token token;
        public Token AuthToken()
        {
             return new Token();
        }

        public void ReceivePaymentMP()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com Mercado Pago");
        }

        public void SendPaymentMP()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com Mercado Pago");
        }
    }
}
