using System;
using Assignment_I___Factory_Method.PaymentGatewayFactories;

namespace Assignment_I___Factory_Method
{
    class Program
    {
        static void Main()
        {
            IPaymentGatewayFactory creditCardFactory = new CreditCardPaymentGatewayFactory();
            IPaymentGateway creditCardGateway = creditCardFactory.CreatePaymentGateway();

            IPaymentGatewayFactory paypalFactory = new PayPalPaymentGatewayFactory();
            IPaymentGateway paypalGateway = paypalFactory.CreatePaymentGateway();

            double paymentAmount = 100.0;
            creditCardGateway.ProcessPayment(paymentAmount);
            paypalGateway.ProcessPayment(paymentAmount);
        }
    }
}