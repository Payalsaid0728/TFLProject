using System.Net.NetworkInformation;
using worldcup;
public class Program
{
    public static void Main(string []srgs)
    {
        Team argentinat=new Team();
        argentinat[0].Name="Lionel Messi";
        Console.WriteLine("palyers:"+argentinat[0].Name);
        string playerName = argentinat[0].Name;
        Console.WriteLine("Selected player: " + playerName);
        argentinat.Display();
    }
}
