using Microsoft.EntityFrameworkCore;
using OnlineStoreServer.Models;

class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(@"Server=DESKTOP-C317JNM;Database=OnlineStoreDB;Trusted_Connection=True;TrustServerCertificate=True;")); // Æåíÿ
        //options.UseSqlServer(@"Server=DESKTOP-C317JNM;Database=OnlineStoreDB;Trusted_Connection=True;TrustServerCertificate=True;")); // Äåíèñ
        builder.Services.AddScoped<DbService>();

        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        // 1) ïðèíèìàåì çàïðîñ íà âõîä!
        app.MapPost("/users/authenticate", async (UserLogin userLogin, DbService dbService) =>
        {
            bool isAuthenticated = await dbService.AuthenticateUserAsync(userLogin.Login, userLogin.Password);
            return Results.Json(new { authenticated = isAuthenticated });
        });

        // 2) ïðèíèìàåì ôîðìó è ïðîâåðÿåì, åñëè óñïåøíî - ðåãèñòðèðóåì
        app.MapPost("/users/register", async (User user, DbService dbService) =>
        {
            bool registrationSuccess = await dbService.RegisterUserAsync(user);
            if (registrationSuccess)
            {
                return Results.Json(new { registered = true, message = "Ïîëüçîâàòåëü óñïåøíî çàðåãèñòðèðîâàí" });
            }
            return Results.Json(new { registered = false, message = "Ïîëüçîâàòåëü ñ òàêèì ëîãèíîì óæå ñóùåñòâóåò" });
        });

        app.Run();
    }
}
