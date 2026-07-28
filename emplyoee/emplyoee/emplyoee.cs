namespace hr;
public class Employee{

    int id;
    string name;
    decimal salary;

// default constructor
    public Employee(){
        
        id=1;
        name="priya";
        salary=10000;
    }

// parameterize constructor 
    public Employee(int id,string name,decimal salary){
        this.id =id;
        this.name=name;
        this.salary=salary;
    }

    public void showinfo(){
        Console.WriteLine("id: " + id);
        Console.WriteLine("name: " + name);
        Console.WriteLine("salary: " + salary);
    }
}

