using System.ComponentModel.DataAnnotations;

namespace Assignment_MN_CMS23.Entities;

internal class AddressEntity
{
    [Key]
    public int Id { get; set; }
    public string StreetName { get; set; } = null!;
    public string PostalCode {  get; set; } = null!;
    public string City { get; set; } = null!;
}
