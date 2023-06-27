
using Microsoft.AspNetCore.Mvc;
using ReportService.Application.Common;
using ReportService.Application.Queries;
using System;

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
        public Task<List<ReportModel>> Get(DateTime monthYear)
        {
            DateTime from = DateTime.MinValue, to = DateTime.MinValue;
            if (monthYear == DateTime.MinValue)
            {
                from = DateTime.Now.AddDays(-2);
                to = DateTime.Now;
            }
            else
            {
                from = new DateTime(monthYear.Year, monthYear.Month, 1);
                to = new DateTime(monthYear.Year, monthYear.Month, DateTime.DaysInMonth(monthYear.Year, monthYear.Month));
            }
            
            return _report.Execute(from, to);
        }
    }
}
