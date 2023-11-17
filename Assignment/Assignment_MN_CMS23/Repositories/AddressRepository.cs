using Assignment_MN_CMS23.Contexts;
using Assignment_MN_CMS23.Entities;

namespace Assignment_MN_CMS23.Repositories;

internal class AddressRepository : Repository<AddressEntity>
{
    public AddressRepository(DataContext context) : base(context)
    {
    }
}
