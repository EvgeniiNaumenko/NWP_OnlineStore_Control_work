using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnlineStoreServer.Models;

class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<ApplicationDbContext>(options =>

        //options.UseSqlServer(@"Server=DESKTOP-C317JNM;Database=OnlineStoreDB;Trusted_Connection=True;TrustServerCertificate=True;")); // Evgenii
        options.UseSqlServer(@"Server=DESKTOP-V6G1V7P;Database=OnlineStoreDB;Trusted_Connection=True;TrustServerCertificate=True;")); // Den

        builder.Services.AddScoped<DbService>();


        var app = builder.Build();
        app.UseStaticFiles();


        //using (var scope = app.Services.CreateScope())
        //{
        //    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        //    dbContext.Database.EnsureDeleted();
        //    dbContext.Database.EnsureCreated();

        //}

        app.MapGet("/", () => "Hello World!");

        // 1) enter
        app.MapPost("/users/authenticate", async (UserLogin userLogin, DbService dbService) =>
        {
            int? userId = await dbService.AuthenticateUserAsync(userLogin.Login, userLogin.Password);

            return Results.Json(userId); 
        });

        // 2) register
        app.MapPost("/users/register", async (User user, DbService dbService) =>
        {
            bool registrationSuccess = await dbService.RegisterUserAsync(user);
            if (registrationSuccess)
            {
                return Results.Json(new { registered = true });
            }
            return Results.Json(new { registered = false});
        });

        //3) add product

        app.MapPost("/products/add", async (ProductRequest productRequest, DbService dbService) =>
        {
            bool success = await dbService.AddProductAsync(productRequest);
            if (success)
            {
                return Results.Json(new { added = true });
            }
            return Results.Json(new { addes = false });
        });

        // 4) get products by UserId
        app.MapGet("/products/user/{userId}", async (int userId, DbService dbService) =>
        {
            var products = await dbService.GetProductsByUserIdAsync(userId);
            return Results.Json(products);
        });

        //5) удалить продукт по id
        app.MapDelete("/products/delete/{id:int}", async (int id, DbService dbService) =>
        {
            bool deleted = await dbService.DeleteProductAsync(id);
            return deleted ? Results.Ok(new { deleted = true }) : Results.NotFound(new { deleted = false });
        });


        app.Run();
    }
}
