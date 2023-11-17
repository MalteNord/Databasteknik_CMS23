namespace Assignment_MN_CMS23.Menus;

internal class MainMenu
{
    private readonly CustomerMenu _customerMenu;
    private readonly ProductMenu _productMenu;

    public MainMenu(CustomerMenu customerMenu, ProductMenu productMenu)
    {
        _customerMenu = customerMenu;
        _productMenu = productMenu;
    }

    public async Task RunAsync()
    {


        do
        {
            Console.Clear();
            Console.WriteLine("Huvudmeny");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Hantera Kunder");
            Console.WriteLine("2. Hantera Produkter");
            Console.WriteLine("0. Avsluta");
            Console.Write("Välj ett alternativ: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    await _customerMenu.ManageCustomers();
                    break;

                case "2":
                    await _productMenu.ManageProducts();
                    break;

                case "0":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Välj ett alternativ!");
                    break;
            }

        }
        while (true);
    }




}
