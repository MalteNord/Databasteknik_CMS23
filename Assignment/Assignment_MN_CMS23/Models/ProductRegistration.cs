namespace Assignment_MN_CMS23.Models;

internal class ProductRegistration
{
    public string ProductName { get; set; } = null!;
    public string ProductDescription { get; set;} = null!;
    public decimal ProductPrice { get; set; }
    public string PricingUnit { get; set; } = null!;
    public string ProductCategory { get; set; } = null!;
}
