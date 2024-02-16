namespace Assignment_I___Factory_Method.PaymentGatewayFactories;


public class PayPalPaymentGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreatePaymentGateway()
    {
        return new PayPalPaymentGateway();
    }
}
