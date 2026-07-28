class Employee
{
    public double basic_sal;
  public virtual double CalculateSalary ()
     {return basic_sal;}
  }


class SalesEmployee:Employee
{ 
  double sales, comm;
  public new double CalculateSalary ()
  {
    return basic_sal+ (sales * comm);
  }
}
public class Program
{
    

public static void Main ()
{ 
  SalesEmployee sper= new SalesEmployee ();
  Double salary= sper.CalculateSalary ();
  Console.WriteLine (salary);
}
}