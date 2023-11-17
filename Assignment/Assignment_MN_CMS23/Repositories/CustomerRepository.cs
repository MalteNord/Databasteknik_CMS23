using Assignment_MN_CMS23.Contexts;
using Assignment_MN_CMS23.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment_MN_CMS23.Repositories;

internal class CustomerRepository : Repository<CustomerEntity>
{

    private readonly DataContext _context;
    public CustomerRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<CustomerEntity>> GetAllAsync()
    {
        return await _context.Customers.Include(x => x.Address).ToListAsync();
    }
}
