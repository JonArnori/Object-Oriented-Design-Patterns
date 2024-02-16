namespace Assignment_I___Factory_Method.PaymentGatewayFactories;

public interface IPaymentGatewayFactory
{
    IPaymentGateway CreatePaymentGateway();
}
