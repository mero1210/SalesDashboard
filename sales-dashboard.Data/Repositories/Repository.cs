using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sales_dashboard.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly DbSet<TEntity> dbSet;

        public Repository(DbContext context)
        {
            this.dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await this.dbSet.Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await this.dbSet.ToListAsync();
        }

        public async Task<TEntity> FindAsync(int id)
        {
            return await this.dbSet.FindAsync(id);
        }
    }
}