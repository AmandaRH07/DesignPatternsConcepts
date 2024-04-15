using System;

namespace Adapter
{
    public class PayPal : IPaypalPayments
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com PayPal");
        }

        public void PayPalReceive()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamentos com PayPal");
        }
    }
}
