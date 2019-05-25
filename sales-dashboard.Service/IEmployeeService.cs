using System.Threading.Tasks;
using sales_dashboard.Service.DTO;

namespace sales_dashboard.Service
{
    public interface IEmployeeService
    {
        Task<EmployeeDTO> LoginAsync(LoginDTO login);
    }
}