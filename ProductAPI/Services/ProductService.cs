using entities;
using System.Collections.Generic;  

namespace ProductAPI.Services;

  

public class ProductService {
  
    
    public static List<Product> GetAll()
  { 
    List<Product> products =new List<Product> ();

    products.Add(new Product{ID=1,Title="Gerbera",Price=20.2});
    products.Add(new Product{ID=2,Title="Rose",Price=52.2});
    products.Add(new Product{ID=3,Title="Lily",Price=12.4});
    products.Add(new Product{ID=4,Title="Tulip",Price=33});
    products.Add(new Product{ID=5,Title="Gerbera",Price=21.5});
  
    return products;
  }

   public static string Insert(){
    Console.WriteLine("data is inserted succesfully");
    return("success");
   }
 }
 

