using sales_dashboard.Domain.Models;

namespace sales_dashboard.Data.Repositories
{
    public class TargetRepository : Repository<Target>, ITargetRepository
    {
        public TargetRepository(SalesDbContext context) : base(context) { }
    }
}