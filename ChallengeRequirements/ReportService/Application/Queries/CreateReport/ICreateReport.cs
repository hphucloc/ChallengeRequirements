using ReportService.Application.Common;

namespace ReportService.Application.Queries
{
    public interface ICreateReport
    {
        List<ReportModel> Execute(DateTime from, DateTime to);
    }
}
