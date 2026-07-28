namespace worldcup;
//content
public class Player
{
    //auto properties
  public int PlayerID{get;set;}
   public string Name{get;set;}
   public int Age{get;set;}
   public string Position{get;set;}
   public int JersyNumber{get;set;}
   public decimal Salary {get;set;}
    public Player(int playerID,string name,int age,string position,int jersyNumber,decimal salary )
    {
        PlayerID = playerID;
        Name= name;
        Age=age;
        Position=position;
        JersyNumber=jersyNumber;
        Salary=salary;
    }
}