using Jordan_C__Final.Models;
using JordanDb.Menus;
using JordanDb.Services;
using Microsoft.Extensions.DependencyInjection;
namespace Jordan_C__Final
{

    internal class Program
    {

        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()

                .AddDbContext<JordanDbContext>()
                .AddScoped<CustomersServices>()
                .AddScoped<ProductsServices>()
                .AddScoped<OrdersServices>()
                 .AddTransient<MainMenu>()
                 .AddTransient<CustomersMenu>()
                 .AddTransient<OrdersMenu>()
                 .AddTransient<ProductsMenu>()
                 .BuildServiceProvider();

            using var scope = serviceProvider.CreateScope();
            var mainMenu = scope.ServiceProvider.GetRequiredService<MainMenu>();
            mainMenu.showMenu();

        }
    }























}