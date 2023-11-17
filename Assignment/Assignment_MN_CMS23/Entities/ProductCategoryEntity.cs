using System.ComponentModel.DataAnnotations;

namespace Assignment_MN_CMS23.Entities;

public class ProductCategoryEntity
{
    [Key]
    public int Id { get; set; }
    public string CategoryName { get; set; } = null!;
}
