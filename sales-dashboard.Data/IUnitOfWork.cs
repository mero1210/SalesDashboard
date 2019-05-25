using sales_dashboard.Data.Repositories;
using System;
using System.Threading.Tasks;

namespace sales_dashboard.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        Task CompleteAsync();
    }
}