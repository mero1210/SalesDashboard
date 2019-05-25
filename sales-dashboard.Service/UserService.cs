using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using sales_dashboard.Data;
using sales_dashboard.Data.Repositories;
using sales_dashboard.Service.DTO;

namespace sales_dashboard.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<UserDTO> LoginAsync(LoginDTO login)
        {
            var findUser = await userRepository.GetAsync(w => w.EmpCode == login.Username);
            if (findUser == null)
            {
                return null;
            }

            var user = findUser.FirstOrDefault();
            if (user.Password == login.Password)
            {
                return mapper.Map<UserDTO>(user);
            }

            return null;
        }
    }
}
