using sales_dashboard.Service.Enum;

namespace sales_dashboard.Service.DTO
{
    public class UserDTO
    {

        public int Id { get; set; }
        public string EmpCode { get; set; }
        public string Password { get; set; }
        public Role UserRoles { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}