using Microsoft.EntityFrameworkCore;
using sales_dashboard.Domain.Models;

namespace sales_dashboard.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SalesDbContext context) : base(context)
        {
        }
    }
}