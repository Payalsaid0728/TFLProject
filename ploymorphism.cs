//polymorphism

//Account.cs
namespace polymorphism;
public class Account
{
    public Decimal Balance{get;set;}
    public virtual void ProcessTransaction(Decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"deposited:{amount},New Balance:{Balance}");
    }
}

//SavingAccount.cs
namespace polymorphism;
public class SavingAccount : Account
{
    public Decimal IntrestRate{get;set;}=0.05m;
    public override void ProcessTransaction(Decimal amount)
    {
       Balance += amount;
       Balance+= Balance*IntrestRate;
       Console.WriteLine($" Saving Account: deposited:{amount},New balance:{Balance}");
    }
}