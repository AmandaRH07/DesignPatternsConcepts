using System;

namespace Adapter
{
    public class Payonner : IPayonnerPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com Payonner");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamentos com Payonner");
        }
    }
}
