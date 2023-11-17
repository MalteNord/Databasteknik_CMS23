using Assignment_MN_CMS23.Contexts;
using Assignment_MN_CMS23.Entities;

namespace Assignment_MN_CMS23.Repositories;

internal class ProductCategoryRepository : Repository<ProductCategoryEntity>
{
    public ProductCategoryRepository(DataContext context) : base(context)
    {
    }
}
