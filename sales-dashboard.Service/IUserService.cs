using System.Threading.Tasks;
using sales_dashboard.Service.DTO;

namespace sales_dashboard.Service
{
    public interface IUserService
    {
        Task<UserDTO> LoginAsync(LoginDTO login);
    }
}