using System.Runtime;
using System.Security.Cryptography.X509Certificates;
namespace Interface;
public interface IAccount
{
    public void Deposite(decimal amount);
    public void Withdraw(decimal amount);
    public void CheckBalance();
}
// Implementing a saving Account

public class SavingAccount : IAccount
{
    private decimal Balance=0;
    private decimal IntrestRate=0.05m;

    public void Deposite(decimal amount)
    {
        Balance += amount+(amount * IntrestRate);
        Console.WriteLine($"Savingaccount:Deposited Amount={amount},New Balance={Balance}");
    }

    public void Withdraw(decimal amount)
    {
        if(Balance>= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Savingaccount:Withdraw Amount={amount},New Balance={Balance}");
        }
        else
        {
            Console.WriteLine($"SavingAccount:Insufficient Balance");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"SavingAccount:Check Balance={Balance}");
    }

}
public class CurrentAccount : IAccount
{
    public decimal Balance=0;
    public decimal overdaftlimit=1000;
    public void Deposite(decimal amount){
        Balance+=amount;
        Console.WriteLine($"Currentaccount:Deposited Amount={amount},New Balance={Balance}");
    }
    
    public void Withdraw(decimal amount)
        {
        if (Balance + overdaftlimit >= amount)
        {
            Console.WriteLine($"CurrentAccount:withdraw amount={amount},New Balance={Balance}");
        }
        else
        {
            Console.WriteLine("CurrentAccount:Insufficient Balance");
        }
        }
        public void CheckBalance()
    {
        Console.WriteLine($"CurrentAccount:Balance={Balance}");
    }
}