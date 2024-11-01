using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnlineStoreServer.Models;
using OnlineStoreServer.Models.Cart;

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


        using (var scope = app.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            //dbContext.Database.EnsureDeleted();
            //dbContext.Database.EnsureCreated();
            //SeedData(dbContext); 
        }

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

        //5) ������� ������� �� id
        app.MapDelete("/products/delete/{id:int}", async (int id, DbService dbService) =>
        {
            bool deleted = await dbService.DeleteProductAsync(id);
            return deleted ? Results.Ok(new { deleted = true }) : Results.NotFound(new { deleted = false });
        });
        // 6) filter requers
        app.MapPost("/products/filter", async (ProductFilterRequest filterRequest, DbService dbService) =>
        {
            var products = await dbService.GetFilteredProductsAsync(filterRequest);
            return Results.Json(products);
        });


        // Cart Methods: 

        // Add
        app.MapPost("/cart/add", async (int userId, int productId, int quantity, DbService dbService) =>
        {
            bool success = await dbService.AddToCartAsync(userId, productId, quantity);
            return Results.Json(new { added = success });
        });

        // Get
        app.MapGet("/cart/user/{userId}", async (int userId, DbService dbService) =>
        {
            var cartItems = await dbService.GetCartItemsAsync(userId);
            return Results.Json(cartItems);
        });

        //  Delete Product From User Cart
        app.MapDelete("/cart/remove", async (int userId, int productId, DbService dbService) =>
        {
            bool success = await dbService.RemoveFromCartAsync(userId, productId);
            return success ? Results.Ok() : Results.NotFound();
        });




        app.Run();
    }

    //������ �����

    private static void SeedData(ApplicationDbContext context)
    {
        // ��������� ������������ � Id = 1
        var user = context.Users.Find(1);
        if (user == null)
        {
            Console.WriteLine("������������ � ID = 1 �� ������.");
            return;
        }

        // ������ ������������ ID ���������
        var existingProductIds = new List<int> { 1, 2 };

        // ���������� ������� � ������� ������������
        foreach (var productId in existingProductIds)
        {
            // ��������, ���������� �� ������� � ���� ������
            var product = context.Products.Find(productId);
            if (product == null)
            {
                Console.WriteLine($"������� � ID = {productId} �� ������ � ���� ������.");
                continue; // ���������� �������, ���� �� �� ������
            }

            var cartItem = new CartItem
            {
                UserId = user.Id,
                ProductId = product.Id,
                Quantity = 1, // ������������� ���������� ������
                User = user,
                Product = product
            };

            user.CartItems.Add(cartItem);
        }

        context.SaveChanges();
    }



}
