using Assignment_MN_CMS23.Contexts;
using Assignment_MN_CMS23.Entities;

namespace Assignment_MN_CMS23.Repositories;

internal class PricingUnitRepository : Repository<PricingUnitEntity>
{
    public PricingUnitRepository(DataContext context) : base(context)
    {
    }
}
