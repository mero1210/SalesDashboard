namespace sales_dashboard.Domain.Models
{
    public class Product
    {
        public string ProductID { get; set; }
        public string Description { get; set; }
        public string Class { get; set; }
        public string Groupings { get; set; }
        public string PSOTeam { get; set; }
        public bool? Active { get; set; }
    }
}