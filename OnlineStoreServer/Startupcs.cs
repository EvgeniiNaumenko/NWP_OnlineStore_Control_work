using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    // Этот метод настраивает службы для приложения.
    public void ConfigureServices(IServiceCollection services)
    {
        // Добавьте службы, если это необходимо
    }

    // Этот метод настраивает приложение.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Позволяет раздавать статические файлы
        app.UseStaticFiles();

        // Здесь вы можете добавить маршруты и другие middleware, если это необходимо
    }
}