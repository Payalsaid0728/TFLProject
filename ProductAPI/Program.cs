using  services;
using entities;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("api/Products",()=>{return "payal,prachi,shreya";});
app.MapGet("/api/products", () =>{return ProductService.GetAll();});
app.MapPost("/api/products",()=>{ return ProductService.Insert();});
app.Run();
