 
using serialization;
using System.Text.Json;
using System.Collections.Generic;
public class Program
{
    public static void Main(string [] args){
        string fileName="Employee.Json";

    List<Employee> employees=new List<Employee>()
    {
        new Employee{
            Id=123,
            Name="payal",
            Salary=1000m
        
    },
    new Employee 
    {
        Id=12,
        Name="prachi",
        Salary=2000m
    }
    };

    RepositoryManager repo=new RepositoryManager();
    repo.Serialize(employees,fileName);
    repo.DeSerialize(fileName);
     foreach (Employee emp in employees)
        {
            Console.WriteLine($"{emp.Id} : {emp.Name}");
        }
    }}
