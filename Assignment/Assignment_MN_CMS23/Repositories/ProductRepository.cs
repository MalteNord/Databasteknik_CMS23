using Assignment_MN_CMS23.Contexts;
using Assignment_MN_CMS23.Entities;
using Assignment_MN_CMS23.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Assignment_MN_CMS23.Repositories;

internal class ProductRepository : Repository<ProductEntity>
{
    private readonly DataContext _context;
    public ProductRepository(DataContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<ProductEntity>> GetAllAsync()
    {
        return await _context.Products
            .Include(x => x.PricingUnit)
            .Include(x => x.ProductCategory)
            .ToListAsync();


    }
}
