
using Microsoft.AspNetCore.Mvc;
using ReportService.Application.Common;
using ReportService.Application.Queries;

namespace ReportService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController: ControllerBase
    {
        public readonly ICreateReport _report;
        public ReportController(ICreateReport report)
        {
            _report= report;
        }

        [HttpGet]
        public List<ReportModel> Get()
        {
            var a = _report.Execute(DateTime.Now, DateTime.Now);

            return a;
        }
    }
}
