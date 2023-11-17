using Assignment_MN_CMS23.Contexts;
using Assignment_MN_CMS23.Menus;
using Assignment_MN_CMS23.Repositories;
using Assignment_MN_CMS23.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment_MN_CMS23
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddDbContext<DataContext>(options => options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malte\source\repos\Assignment\Assignment_MN_CMS23\Contexts\database.mdf;Integrated Security=True;Connect Timeout=30"));

            // Repos
            services.AddScoped<AddressRepository>();
            services.AddScoped<CustomerRepository>();
            services.AddScoped<PricingUnitRepository>();
            services.AddScoped<ProductRepository>();
            services.AddScoped<ProductCategoryRepository>();



            // Services
            services.AddScoped<CustomerService>();
            services.AddScoped<ProductService>();

            // Menus
            services.AddScoped<MainMenu>();
            services.AddScoped<CustomerMenu>();
            services.AddScoped<ProductMenu>();





            var sp = services.BuildServiceProvider();
            var mainMenu = sp.GetRequiredService<MainMenu>();
            await mainMenu.RunAsync();
        }
    }
}
