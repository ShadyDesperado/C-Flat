using JordanDb.Services;
using Jordan_C__Final.Models;
using static System.Console;
using Microsoft.Extensions.DependencyInjection;

namespace JordanDb.Menus
{
    public class MainMenu
    {
        private readonly IServiceProvider _serviceProvider;

        public MainMenu(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void showMenu()
        {
            bool isOpen = true;
            while (isOpen)
            {
                WriteLine("Shop Management Menu! Please enter 1-3: ");
                WriteLine("1) Customers Menu");
                WriteLine("2) Orders Menu");
                WriteLine("3) Products Menu");
                string input = ReadLine();
                switch (input)
                {
                    case "1":
                        var customersMenu = _serviceProvider.GetRequiredService<CustomersMenu>();
                        customersMenu.showMenu();
                        break;
                    case "2":
                        var ordersMenu = _serviceProvider.GetRequiredService<OrdersMenu>();
                        ordersMenu.showMenu();
                        break;
                    case "3":
                        var productsMenu = _serviceProvider.GetRequiredService<ProductsMenu>();
                        productsMenu.showMenu();
                        break;
                    default:
                        WriteLine("\nGoodbye!\n");
                        isOpen = false;
                        break;
                }
            }
        }
    }
}