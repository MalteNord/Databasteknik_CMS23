using Assignment_MN_CMS23.Models;
using Assignment_MN_CMS23.Services;
using System.Linq.Expressions;

namespace Assignment_MN_CMS23.Menus;

internal class CustomerMenu
{

    private readonly CustomerService _customerService;

    public CustomerMenu(CustomerService customerService)
    {
        _customerService = customerService;
    }

    public async Task ManageCustomers()
    {
        Console.Clear();
        Console.WriteLine("Hantera kunder");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1. Skapa ny kund");
        Console.WriteLine("2. Skriv ut alla kunder");
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
        var form = new CustomerRegistration();

        Console.Clear();
        Console.WriteLine("Skapa ny kund");
        Console.WriteLine("---------------------------------");
        Console.Write("Förnamn: ");
        form.FirstName = Console.ReadLine()!;

        Console.Write("Efternamn: ");
        form.LastName = Console.ReadLine()!;

        Console.Write("Email: ");
        form.Email = Console.ReadLine()!;

        Console.Write("Gatunamn: ");
        form.StreetName = Console.ReadLine()!;

        Console.Write("Postnummer: ");
        form.PostalCode = Console.ReadLine()!;

        Console.Write("Stad: ");
        form.City = Console.ReadLine()!;

        var result = await _customerService.CreateCustomerAsync(form);
        if (result)
            Console.WriteLine("Kunden skapades!");
        else
            Console.WriteLine("Lyckades inte skapa kunden.");

        Console.ReadKey();
    }

    public async Task ListAllAsync()
    {
        Console.Clear();

        var customers = await _customerService.GetAllAsync();
        foreach (var customer in customers)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            Console.WriteLine($"{customer.Address.StreetName}, {customer.Address.PostalCode}, {customer.Address.City}");
            Console.WriteLine("");
        }

        Console.ReadKey();
    }

}
