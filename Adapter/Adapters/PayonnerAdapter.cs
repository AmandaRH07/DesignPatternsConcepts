using System;

namespace Adapter
{
    public class PayonnerAdapter : IPaypalPayments
    {
        private Payonner payonner;

        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
            Console.WriteLine("Realizando Adaptação de" +
                " Payonner para os métodos do PayPal");
        }

        public Token AuthToken()
        {
            return this.payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            this.payonner.SendPayment();
        }

        public void PayPalReceive()
        {
            this.payonner.ReceivePayment();
        }
    }
}
