using Adapter.Adapters;
using Adapter.Interfaces;
using System;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            PayPal paypalPayment = new PayPal();
            paypalPayment.PayPalPayment();
            paypalPayment.PayPalReceive();

            Payonner payoneerPayment = new Payonner();
            payoneerPayment.SendPayment();
            payoneerPayment.ReceivePayment();

            IPaypalPayments payoneerPaymentAdapter = new PayonnerAdapter(new Payonner());
            payoneerPaymentAdapter.PayPalPayment();
            payoneerPaymentAdapter.PayPalReceive();

            IMercadoPagoPayments mpPayments = new MercadoPagoAdapter(new MercadoPago());
            mpPayments.SendPaymentMP();
            mpPayments.ReceivePaymentMP();

            Console.ReadLine();

        }
    }
}
