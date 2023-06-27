using ReportService.Application.Common;

namespace ReportService.Application.Queries
{
    public interface ICreateReport
    {
        Task<List<ReportModel>> Execute(DateTime from, DateTime to);
    }
}
