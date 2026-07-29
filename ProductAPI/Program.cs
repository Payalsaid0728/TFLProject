using entities;
using ProductAPI.Services;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("api/Customers",()=>{return "payal,prachi,shreya";});
app.MapGet("/api/products",() =>{return ProductService.GetAll();});
app.MapPost("/api/products",()=>{return ProductService.Insert();});
app.Run();
