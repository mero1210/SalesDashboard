using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using sales_dashboard.Helpers;
using sales_dashboard.Service;
using sales_dashboard.Service.DTO;

namespace sales_dashboard.Controllers
{
    [Route("api/[controller]")]
    public class AuthenticationController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly IOptions<AppSettings> appSettings;

        public AuthenticationController(IEmployeeService employeeService,
            IOptions<AppSettings> appSettings)
        {
            this.employeeService = employeeService;
            this.appSettings = appSettings;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync([FromBody]LoginDTO login)
        {
            if (login == null) 
            {
                return Unauthorized("Invalid username and password");
            }

            var user = await employeeService.LoginAsync(login);
            if (user == null)
            {
                return Unauthorized("Invalid username and password");
            }

            return Ok(new { token = TokenHelper.GenerateToken(user, appSettings.Value.SecurityKey) });
        }
    }
}