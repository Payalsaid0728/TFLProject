using calculator;
public class Program
{
    public delegate void CalDelegate(int x,int y);
    public static void Main(string[] args)
    {
        CalDelegate Addition = new CalDelegate(Method.Add);
        CalDelegate Substraction = new CalDelegate(Method.Sub);

        CalDelegate Master0=null;
        Master0+=Addition;
        Master0+=Substraction;
        Master0(30,20);
        //  Addition(10,20);
        //  Substraction(20,10);
     }
} 
