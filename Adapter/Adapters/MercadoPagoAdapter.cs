using Adapter.Interfaces;
using System;

namespace Adapter.Adapters
{
    public class MercadoPagoAdapter : IMercadoPagoPayments
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Realizando Adaptação de " +
                "MercadoPago para os métodos do MercadoPago");
        }

        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void SendPaymentMP()
        {
            this.mercadoPago.SendPaymentMP();
        }

        public void ReceivePaymentMP()
        {
            this.mercadoPago.ReceivePaymentMP();
        }
    }
}
