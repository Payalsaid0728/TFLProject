##Student.cs

// crating a namespace
namespace Teacher;

// creating a class 
public class Student{
//Initializing DataMember
 int Id;
 string Name;
 string Class;
 string Department;
 int Age;
}

//   Creating Default Constructor
public Student(){
this.Id=1;
this.Name="Payal";
this.Class="SE";
this,Department="Computer";
this.Age=20;
}

// Creating Parameterized Constructor
public Student(int id,string name, string class,string department,int age){
this.Id=id;
this.Name=name;
this.Class=class;
this,Department=deparment;
this.Age=age;
}

//Display  Method
public void Display(){
Console.WriteLine("Id="+Id);
Console.WriteLine("Name="Name);
Console.WriteLine("Class="+Class);
Console.WriteLine("Department="+Department);
Console.WriteLine("Age="+Age);
}

##Program.cs
//use the namespace
using Teacher;
//create class
public class Program
{
// main method
public static void Main(string [] args)
{
// crating object of student class
Student std1=new Student();
Student std2=new Student(2,"prachi","SE","Computer",21);
std1.Display();
std2.Display();
}



