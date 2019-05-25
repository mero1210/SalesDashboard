namespace sales_dashboard.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string EmpCode { get; set; }
        public string Password { get; set; }
        public int UserRoles { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}