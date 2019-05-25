using Microsoft.EntityFrameworkCore;
using sales_dashboard.Domain.Models;

namespace sales_dashboard.Data.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EtmsDbContext context) : base(context)
        {
        }
    }
}