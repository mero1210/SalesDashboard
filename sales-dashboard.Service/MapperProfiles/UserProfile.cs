using AutoMapper;
using sales_dashboard.Domain.Models;
using sales_dashboard.Service.DTO;

namespace sales_dashboard.Service.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
                .ReverseMap();
        }
    }
}