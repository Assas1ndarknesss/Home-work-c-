// // Car car = new Car(0);
// // car.Drive();
// // car.Refuel(Convert.ToInt32(Console.ReadLine()));
// // car.Drive();

// BankAccout bankAccout = new BankAccout(992, "Alesha");
// PayPalPayment payPal = new PayPalPayment();
// CashPayment cashPayment = new CashPayment();
// CreditCardPayment card = new CreditCardPayment();

// while (true)
// {
//     System.Console.WriteLine();
//     System.Console.WriteLine("1. Add Money");
//     System.Console.WriteLine("2. Withdraw Money");
//     System.Console.WriteLine("3. By Cash");
//     System.Console.WriteLine("4. By PayPal");
//     System.Console.WriteLine("5. By CreditCard");
//     System.Console.WriteLine("6. Exit");
//     System.Console.WriteLine();
//     string function = Console.ReadLine();
//     System.Console.WriteLine();
//     if (function == "1")
//     {
//         System.Console.Write("Adding money:");
//         bankAccout.TopUp(Convert.ToInt32(Console.ReadLine()));
//         bankAccout.PrintStatement();
//     }
//     if (function == "2")
//     {
//         System.Console.Write("Withdraw money:");
//         bankAccout.Withdraw(Convert.ToInt32(Console.ReadLine()));
//         bankAccout.PrintStatement();
//     }
//     if (function == "3")
//     {
//         System.Console.Write("How much?");
//         decimal amount = Convert.ToDecimal(Console.ReadLine());
//         cashPayment.ProcessPayment(amount);
//         bankAccout.PrintStatement();
//     }
//     if (function == "4")
//     {
//         System.Console.Write("How much?");
//         decimal amount = Convert.ToDecimal(Console.ReadLine());
//         payPal.ProcessPayment(amount);
//         bankAccout.PrintStatement();
//     }
//     if (function == "5")
//     {
//         System.Console.Write("How much?");
//         decimal amount = Convert.ToDecimal(Console.ReadLine());
//         card.ProcessPayment(amount);
//         bankAccout.PrintStatement();
//     }
//     if (function == "6")
//     {
//         break;
//     }
// }


static void Math()
{
    double PI = 3.14;

    static int Min(int a, int b)
    {
        if (a > b)
        {
            return b;
        }
        else
        {
            return a;
        }
    }
    
}
