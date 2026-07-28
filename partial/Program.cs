using partial;
public class Program
{
    public static void Main(string[] args)
    {
        Bankaccount Account = new Bankaccount();
        Account.AccountNumber="123456";
        Account.CustomerName="ABCD";
        Account.Balance=1000m;

        Account.Deposit(100m);
        Account.Withdraw(200m);
        Account.ApplyIntrest(0.05m);
        
    }
}
