using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using sales_dashboard.Data.Repositories;
using sales_dashboard.Service.DTO;

namespace sales_dashboard.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        public EmployeeService(IEmployeeRepository employeeRepository,
            IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }

        public async Task<EmployeeDTO> LoginAsync(LoginDTO login)
        {
            if (login == null)
            {
                return null;
            }

            var findEmployee = await employeeRepository.GetAsync(w => w.Empcode == login.Username);
            if (findEmployee == null)
            {
                return null;
            }

            var employee = findEmployee.FirstOrDefault();
            if (employee.Password == login.Password)
            {
                return mapper.Map<EmployeeDTO>(employee);
            }

            return null;
        }
    }
}