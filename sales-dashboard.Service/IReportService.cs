using System.Threading.Tasks;
using sales_dashboard.Service.DTO;

namespace sales_dashboard.Service
{
    public interface IReportService
    {
        Task<ReportDTO> GetSummary(int year, int month);
    }
}