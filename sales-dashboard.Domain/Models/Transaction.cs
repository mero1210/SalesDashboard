namespace sales_dashboard.Domain.Models
{
    public class Transaction
    {
        // public string RSMCode { get; set; }
        // public string TeamCode { get; set; }
        // public string AreaCode { get; set; }
        // public string PSORegion { get; set; }
        // public string PSOTeam { get; set; }
        // public string PSOCode { get; set; }
        public string CustomerCode { get; set; }
        public string ProductID { get; set; }
        // public string ProductCode { get; set; }
        public double? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        // public string DataID { get; set; }
        // public string TranDate { get; set; }
        // public string ORSMCode { get; set; }
        // public string OTeamCode { get; set; }
        // public string OAreaCode { get; set; }
        // public string refno { get; set; }
        public string monthv { get; set; }
        public string yearv { get; set; }
        //public string Filename { get; set; }
        // public bool? Status { get; set; }
        // public string DateTran { get; set; }
        // public string MRType { get; set; }
        // public string Remarks { get; set; }
        // public string Division { get; set; }
        // public string ZoneID { get; set; }
        // public string PresID { get; set; }
        // public string MDID { get; set; }
        // public string MDCode { get; set; }
    }
}