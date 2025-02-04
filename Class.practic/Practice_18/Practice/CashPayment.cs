public class CashPayment : IPayment
{
     public void ProcessPayment(decimal amount){

        System.Console.WriteLine("Payment finish by Cash");
    }
}