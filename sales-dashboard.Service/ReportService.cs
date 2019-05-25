using System.Threading.Tasks;
using sales_dashboard.Data.Repositories;
using sales_dashboard.Service.DTO;
using System.Linq;

namespace sales_dashboard.Service
{
    public class ReportService : IReportService
    {
        private readonly ITargetRepository targetRepository;
        private readonly ITransactionRepository transactionRepository;
        private readonly IProductRepository productRepository;

        public ReportService(ITargetRepository targetRepository,
            ITransactionRepository transactionRepository,
            IProductRepository productRepository)
        {
            this.targetRepository = targetRepository;
            this.transactionRepository = transactionRepository;
            this.productRepository = productRepository;
        }

        public async Task<ReportDTO> GetSummary(int year, int month)
        {
            var result = new ReportDTO("Sales Report Summary", "");
            var previousYear = (year - 1).ToString();
            var yearStr = year.ToString();
            var monthStr = month.ToString().PadLeft(2, '0');

            var target = await targetRepository
                .GetAsync(w => (w.Year == yearStr || w.Year == previousYear) && w.Month == monthStr);
            var actual = await transactionRepository
                .GetAsync(w => (w.yearv == yearStr || w.yearv == previousYear) && w.monthv == monthStr);
            //var products = await productRepository.GetAsync();

            var qResult = from t in target
                          join a in actual on new { t.Year, t.Month } equals new { Year = a.yearv, Month = a.monthv } into at
                          select new { t.Year, t.Month, Sum = at.Sum(s => s.Amount) };
            result.Data = qResult;
            
            return result;
        }
    }
}