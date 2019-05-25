using System;
using Microsoft.EntityFrameworkCore;
using sales_dashboard.Domain.Models;

namespace sales_dashboard.Data
{
    public class SalesDbContext : DbContext
    {
        public DbSet<Target> Target { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Product> Products { get; set; }
        
        public SalesDbContext() {}

        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Target>()
                .ToTable("EmployeeTarget")
                .HasKey(k => new { k.AreaID, k.ProductID });
            builder.Entity<Transaction>()
                .ToTable("Transactions")
                .HasKey(k => new { k.ProductID, k.yearv, k.monthv });
            builder.Entity<Product>()
                .ToTable("Products")
                .HasKey(k => k.ProductID);
        }
    }
}
