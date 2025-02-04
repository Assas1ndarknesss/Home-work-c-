public class BankAccout : IBankOperations
{
    public int AccountNumber { get; set; }
    public string Owner { get; set; }
    private decimal Balance;

    public BankAccout(int AccountNumber, string Owner)
    {
        this.AccountNumber = AccountNumber;
        this.Owner = Owner;
        this.Balance = 0;
    }
    public void TopUp(decimal amount)
    {
        Balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        if (this.Balance > 0)
        {
            this.Balance -= amount;
        }
    }
    public void PrintStatement(){
        System.Console.WriteLine($"Owner AccountNumber: {this.AccountNumber}");
        System.Console.WriteLine($"Owner Name: {this.Owner}");
        System.Console.WriteLine($"Owner Balance: {this.Balance}");
    }
}