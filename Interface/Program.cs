using Interface;
public class Program
{
    public static void Main(string [] args)
    {
         IAccount account = new SavingAccount();
        account.Deposite(1000);
        account.Withdraw(200);
        account.CheckBalance();

        IAccount acc=new CurrentAccount(); 
        acc.Deposite(1000);
        acc.Withdraw(300);
        acc.CheckBalance();

    }

}