namespace account;

public class Account
{
    public decimal Balance{get;set;}
    public void Deposit(decimal amount)
    {
        Balance+=amount;
        Console.WriteLine($"deposited {amount}.New Balance {Balance}");
    }
    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance-=amount;
            Console.WriteLine($"withdrawn {amount}.New Balance{Balance}");
        }
        else
        {
            Console.WriteLine("insufficient balance");
        }
    }
}

