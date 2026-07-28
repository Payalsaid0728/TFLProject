namespace partial;
public partial class Bankaccount
{
    public void Deposit(decimal amount)
    {
        Balance+=amount;

        
        Console.WriteLine($"{CustomerName}deposited Amount:{amount},New Balance:{Balance}");
   } 
   public void Withdraw(decimal amount)
    {
        if(Balance>= amount)
        {
            Balance-=amount;
            Console.WriteLine($"{CustomerName }withdraw Amount:{amount},New Balance:{Balance}");
        }
        else
        {
            Console.WriteLine($"Insufficient Balance");
        }
    }
 
 public void ApplyIntrest(decimal rate)
    {
        Balance+=Balance*rate;
        Console.WriteLine($"Interest Applied:{rate},New Balance:{Balance}");
    }
    }