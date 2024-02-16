namespace Assignment_I___Factory_Method.PaymentGatewayFactories;


public class CreditCardPaymentGateway : IPaymentGateway
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}");
     
    }
}
