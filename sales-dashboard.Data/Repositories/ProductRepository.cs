using Microsoft.EntityFrameworkCore;
using sales_dashboard.Domain.Models;

namespace sales_dashboard.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(SalesDbContext context) : base(context) {}
    }
}