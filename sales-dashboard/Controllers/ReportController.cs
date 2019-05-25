using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sales_dashboard.Service;

namespace sales_dashboard.Controllers
{
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        private readonly IReportService reportService;

        public ReportController(IReportService reportService)
        {
            this.reportService = reportService;
        }

        [HttpGet]
        [Route("GetSummary")]
        public async Task<IActionResult> GetSummary(int year, int month)
        {
            var result = await reportService.GetSummary(year, month);
            return Ok(result);
        }
    }
}