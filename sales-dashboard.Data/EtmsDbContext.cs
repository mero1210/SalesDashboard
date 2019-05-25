using Microsoft.EntityFrameworkCore;
using sales_dashboard.Domain.Models;

namespace sales_dashboard.Data
{
    public class EtmsDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EtmsDbContext() : base() {}
        public EtmsDbContext(DbContextOptions<EtmsDbContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
                .ToTable("Employee")
                .HasKey(k => k.Empcode);
        }
    }
}