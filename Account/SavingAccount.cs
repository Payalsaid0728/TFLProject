// Child class
namespace account;
public class SavingAccount: Account
{
    public decimal Interest {get;set;}=0.05m;
    public void ApplyInterest(){
    Balance=Balance*Interest;
    Console.WriteLine($"interestapplied{Interest}.New Balance{Balance}");
    }
}


