using ReportService.Infrastructure.Common;

namespace ReportService.Infrastructure.GetList
{
    public interface IGetOrderList
    {
        Task<List<OrderModel>> Execute(DateTime from, DateTime to);
    }
}
