namespace Adapter
{
    public interface IPaypalPayments
    {
        Token AuthToken();
        void PayPalPayment();
        void PayPalReceive();
    }
}
