using Assignment_MN_CMS23.Models;
using Assignment_MN_CMS23.Services;

namespace Assignment_MN_CMS23.Menus;

internal class ProductMenu
{
    private readonly ProductService _productService;

    public ProductMenu(ProductService productService)
    {
        _productService = productService;
    }

    public async Task ManageProducts()
    {
        Console.Clear();
        Console.WriteLine("Hantera produkter");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1. Skapa ny produkt");
        Console.WriteLine("1. Skriv ut alla produkter");
        Console.Write("Välj ett alternativ: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                await CreateAsync();
                break;

            case "2":
                await ListAllAsync();
                break;
        }
    }

    public async Task CreateAsync()
    {
        var form = new ProductRegistration();

        Console.Clear();
        Console.WriteLine("Skapa ny produkt");
        Console.WriteLine("---------------------------------");
        Console.Write("Namn på produkt: ");
        form.ProductName = Console.ReadLine()!;

        Console.Write("Beskrivning: ");
        form.ProductDescription = Console.ReadLine()!;

        Console.Write("Kategori: ");
        form.ProductCategory = Console.ReadLine()!;

        Console.Write("Pris (SEK): ");
        form.ProductPrice = decimal.Parse(Console.ReadLine()!);

        Console.WriteLine("Prisenhet (st/pkt/tim)");
        form.PricingUnit = Console.ReadLine()!;



        var result = await _productService.CreateProductAsync(form);
        if (result)
            Console.WriteLine("Produkten skapades!");
        else
            Console.WriteLine("Lyckades inte skapa produkten.");

        Console.ReadKey();
    }

    public async Task ListAllAsync()
    {
        Console.Clear();

        var products = await _productService.GetAllAsync();
        foreach (var product in products)
        {
            Console.WriteLine($"{product.ProductName} ({product.ProductCategory.CategoryName})");
            Console.WriteLine($"{product.ProductPrice} ({product.PricingUnit.Unit})");
            Console.WriteLine("");
        }

        Console.ReadKey();
    }
}
