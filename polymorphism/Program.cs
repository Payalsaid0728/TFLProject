using polymorphism;
public class Program
{
    public static void Main(string[]args)
    {
        Account acc1=new SavingAccount();
        Account acc2=new CurrentAccount();
        acc1.ProcessTransaction(1000m);
        acc2.ProcessTransaction(2000m);
    }
}
