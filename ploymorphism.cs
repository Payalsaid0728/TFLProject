## Polymorphism

#Account.cs
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

