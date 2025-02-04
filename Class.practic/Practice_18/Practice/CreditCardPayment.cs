public class CreditCardPayment : IPayment
{
    public void ProcessPayment(decimal amount){

        System.Console.WriteLine("Payment finish by CreditCard");
    }
}