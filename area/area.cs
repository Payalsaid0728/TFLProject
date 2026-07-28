// // // public class Area

// // // {
// // //    static void swap(ref int a,ref int b)
// // //     {
// // //         int temp=a;
// // //         a=b;
// // //         b=temp;
// // //     }
// // //     public static void Main(string  [] args)
// // //     {
// // //         int x=10;
// // //         int y=20;
// // //         swap(ref x,ref y);
// // //         Console.WriteLine("x:"+x);
// // //         Console.WriteLine("y:"+y);
// // //     }
// // // }




// // public class Area
// // {
// //     public static void calculate(int r,out float area,out float perimeter)
// //     {
// //         area=3.14f*r*r;
// //         perimeter=2*3.14f*r;
// //     }
// //     public static void Main(string [] args)
// //     {
// //         float area1;
// //         float perimeter1;
// //         calculate(5,out area1,out perimeter1);
// //         Console.WriteLine(area1);
// //         Console.WriteLine(perimeter1);
// //     }
// // }



// public class Area
// {
//     static void Viewnames(params string[] names)
//     {
//         foreach(var name in names)
//         Console.WriteLine(name);
//     }
//     public static void Main(string [] args)
//     {
//         Viewnames("payal","prachi");
//         Viewnames("payal","prachi","vaishnavi");
//         Viewnames("payal","prachi","vaishnavi","vaibhavi");
//     }
// }



public class Area
{
    static void ViewNames(params string[] names)
    {
        foreach(var name in names)
        Console.WriteLine(name);
    }
    public static void Main(string[]args)
{
        ViewNames("payal","prachi" );
        ViewNames("payal","prachi","srushti");  
         }
}