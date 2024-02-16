namespace Assignment_I___Factory_Method.PaymentGatewayFactories;

public class PayPalPaymentGateway : IPaymentGateway
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount}");
    }
}
