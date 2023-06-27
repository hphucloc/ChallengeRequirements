
using Microsoft.AspNetCore.Mvc;
using ReportService.Application.Common;

namespace StoreService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController: ControllerBase
    {
        public readonly ICreateReport _report;
        public ReportController(CreateReport report)
        {
            _report= report;
        }

        [HttpGet]
        public List<ReportModel> Get()
        {
            return _report.Execute();
        }
    }
}
