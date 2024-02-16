namespace Assignment_I___Factory_Method.PaymentGatewayFactories;

public class CreditCardPaymentGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreatePaymentGateway()
    {
        return new CreditCardPaymentGateway();
    }
}
