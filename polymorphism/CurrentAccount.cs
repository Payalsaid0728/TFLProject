namespace polymorphism;
public class CurrentAccount: Account
{
    public override void ProcessTransaction(Decimal amount)
    {
        Balance+=amount;
        Console.WriteLine($" Current Account : deposited:{amount} , New Balance:{Balance}");
    }
}