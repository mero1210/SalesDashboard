using sales_dashboard.Domain.Models;

namespace sales_dashboard.Data.Repositories
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(SalesDbContext context) : base(context)
        {
        }
    }
}