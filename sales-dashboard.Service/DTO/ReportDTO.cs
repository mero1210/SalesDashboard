namespace sales_dashboard.Service.DTO
{
    public class ReportDTO
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public object Data { get; set; }
        
        public ReportDTO() {}
        public ReportDTO(string title, string subTitle)
        {
            this.Title = title;
            this.SubTitle = subTitle;
        }
    }
}
