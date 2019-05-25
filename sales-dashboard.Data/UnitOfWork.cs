using System.Threading.Tasks;
using sales_dashboard.Data.Repositories;

namespace sales_dashboard.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SalesDbContext context;

        public IUserRepository Users { get; private set; }

        public UnitOfWork(SalesDbContext context)
        {
            this.context = context;

            this.Users = new UserRepository(this.context);
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}