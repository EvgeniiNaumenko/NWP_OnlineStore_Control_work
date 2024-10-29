using System.Xml.Linq;
using System;
using OnlineStoreServer.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;

//var context = new ApplicationDbContext();

//var dbService = new DbService(context);

var builder = WebApplication.CreateBuilder();

// –егистраци€ ApplicationDbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// –егистраци€ DbService
builder.Services.AddScoped<DbService>();


var app = builder.Build();

//1) принимаем запрос на вход!
app.MapPost("/users/authenticate", async (UserLogin userLogin, DbService dbService) =>
{
    bool isAuthenticated = await dbService.AuthenticateUserAsync(userLogin.Login, userLogin.Password);
    return Results.Json(new { authenticated = isAuthenticated });
});
//2 принимаем форму и провер€ем если успешно регистрируем
app.MapPost("/users/register", async (User user, DbService dbService) =>
{
    bool registrationSuccess = await dbService.RegisterUserAsync(user);
    if (registrationSuccess)
    {
        return Results.Json(new { registered = true, message = "ѕользователь успешно зарегистрирован" });
    }
    return Results.Json(new { registered = false, message = "ѕользователь с таким логином уже существует" });
});


//app.MapGet("/users/{id}", async (int id) => 
//{
//    User? user = await dbService.GetUserByIdAsync(id);
//    if (user == null)
//    {
//        return Results.NotFound(new { message = "ѕользователь не найден" });
//    }
//    return Results.Json(user);
//});

//app.MapGet("/product/{id}", async (int id) =>
//{
//    Product? product = await dbService.GetProductByIdAsync(id);
//    if (product == null)
//    {
//        return Results.NotFound(new { message = "ѕродукт не найден" });
//    }
//    return Results.Json(product);
//});

app.Run();

//app.MapDelete("/api/users/{id}", (int id) => //удаление пользовател€ и вернет пользовател€ в ответ
//{
//    Person? user = users.FirstOrDefault(u => u.Id == id);
//    if (user == null)
//    {
//        return Results.NotFound(new { message = "ѕользователь не найден" });
//    }


//    users.Remove(user);
//    return Results.Json(user);
//});


//app.MapPost("/api/users", (Person user) => // возвращает обьект
//{
//    user.Id = id++;
//    users.Add(user);
//    return user;
//});


//app.MapPut("/api/users", (Person userData) => // обновление изменит или вернет NotFaund
//{
//    var user = users.FirstOrDefault(u => u.Id == userData.Id);
//    if (user == null)
//    {
//        return Results.NotFound(new { message = "ѕользователь не найден" });
//    }


//    user.Age = userData.Age;
//    user.Name = userData.Name;
//    return Results.Json(user);
//});


//app.Run();

//public class Person
//{
//    public int Id { get; set; }
//    public string Name { get; set; } = "";
//    public int Age { get; set; }
//}