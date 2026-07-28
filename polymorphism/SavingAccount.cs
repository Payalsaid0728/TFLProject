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