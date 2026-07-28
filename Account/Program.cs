using account;
public class Program
{
    public static void Main(string[] args)
    {
        SavingAccount account = new SavingAccount();
        account.Deposit(1000m);
        account.Withdraw(200m);
        account.ApplyInterest();
    }
}
