using Events;
public class Program
{
    public static void Main(string[] args)
    {
        Account Myaccount=new Account(200);
        Myaccount.UnderBalance+=PayPanlty;
        Myaccount.UnderBalance+=BlockBankAccount;
        Myaccount.OverBalance+=PayIncomeTax;
        Myaccount.OverBalance+=PayProfessionalTax;

        Myaccount.Withdraw(200);
    }
    public static void PayPanlty()
    {
        Console.WriteLine("Pay 500rs");
    }
    
    public static void BlockBankAccount()
    {
        Console.WriteLine("your bank account is block");
    }
    
    public static void PayIncomeTax()
    {
        Console.WriteLine("you have to pay 10% tax");
    }
    
    public static void PayProfessionalTax()
    {
        Console.WriteLine("you have to pay 10% tax");
    }
}

