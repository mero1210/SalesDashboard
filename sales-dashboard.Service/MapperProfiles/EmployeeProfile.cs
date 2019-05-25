using AutoMapper;
using sales_dashboard.Domain.Models;
using sales_dashboard.Service.DTO;

namespace sales_dashboard.Service.MapperProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDTO>();
        }
    }
}