using System.Diagnostics;

public class PayPalPayment : IPayment
{
    public void ProcessPayment(decimal amount){

        System.Console.WriteLine("Payment finish by PayPal");
    }
}