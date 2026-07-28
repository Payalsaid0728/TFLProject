using System.Security.Cryptography.X509Certificates;

namespace Events;
public delegate void AccountOperation();
public class Account
{
    public decimal Balance;
    public event AccountOperation? UnderBalance;
    public event AccountOperation? OverBalance;
    public Account(int amount)
    {
        Balance=amount;
    }

    public void deposit(int amount)
    {
        Balance+=amount;
        if (Balance > 1000)
         UnderBalance();
        
    }
     public void Withdraw(int amount)
    {
        Balance-=amount;
        if (Balance < 500)
            OverBalance();
         }
}