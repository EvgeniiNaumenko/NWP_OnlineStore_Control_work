using Microsoft.EntityFrameworkCore;
using OnlineStoreServer.Models;

class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(@"Server=DESKTOP-C317JNM;Database=OnlineStoreDB;Trusted_Connection=True;TrustServerCertificate=True;")); // ����
        //options.UseSqlServer(@"Server=DESKTOP-C317JNM;Database=OnlineStoreDB;Trusted_Connection=True;TrustServerCertificate=True;")); // �����
        builder.Services.AddScoped<DbService>();

        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        // 1) ��������� ������ �� ����!
        app.MapPost("/users/authenticate", async (UserLogin userLogin, DbService dbService) =>
        {
            bool isAuthenticated = await dbService.AuthenticateUserAsync(userLogin.Login, userLogin.Password);
            return Results.Json(new { authenticated = isAuthenticated });
        });

        // 2) ��������� ����� � ���������, ���� ������� - ������������
        app.MapPost("/users/register", async (User user, DbService dbService) =>
        {
            bool registrationSuccess = await dbService.RegisterUserAsync(user);
            if (registrationSuccess)
            {
                return Results.Json(new { registered = true, message = "������������ ������� ���������������" });
            }
            return Results.Json(new { registered = false, message = "������������ � ����� ������� ��� ����������" });
        });

        app.Run();
    }
}
