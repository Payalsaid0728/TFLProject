
namespace delegateExample;
public class Program{
    public delegate void Mydelegate(int OrderID);
    public static void ProcessOrder(int OrderID)
    {
        Console.WriteLine($"{OrderID} Order is in Processing");
    }
    public static void CancelOrder(int OrderID)
    {
        Console.WriteLine($"{OrderID} Order is  Cancel");
    }

public static void Main(string[] args)
    {
        Mydelegate o1= new Mydelegate(ProcessOrder);
        o1= CancelOrder;
        o1.Invoke(2);

        // Mydelegate MasterO= null;
        // MasterO+=o1;
        // MasterO+=o2;

        // MasterO.Invoke(1);

    }

} 
