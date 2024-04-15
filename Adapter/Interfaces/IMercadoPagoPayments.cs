namespace Adapter.Interfaces
{
    public interface IMercadoPagoPayments
    {
        Token AuthToken();

        void ReceivePaymentMP();

        void SendPaymentMP();
    }
}
