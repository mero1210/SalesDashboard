using System;

namespace sales_dashboard.Domain.Models
{
    public class Employee
    {
        public string Empcode { get; set; }
        public string UsertypeID { get; set; }
        public int? UserLevel { get; set; }
        public int? UserClass { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public DateTime? ConfigCode { get; set; }
        public string ETMSCode { get; set; }
        public string AreaCode { get; set; }
        public string RegionCode { get; set; }
        public string Superior { get; set; }
        public int? Subordinates { get; set; }
        public string BusinessType { get; set; }
        public string Email { get; set; }
        public bool? Resigned { get; set; }
        public bool? Payroll { get; set; }
        public string CellNo { get; set; }
        public int? BankRef { get; set; }
        public string Position { get; set; }
        public bool? GMA { get; set; }
        public string MobUserTypeID { get; set; }
    }
}