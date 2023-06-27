

using ReportService.Application.Common;
using ReportService.Infrastructure.Common;
using ReportService.Infrastructure.GetList;

namespace ReportService.Application.Queries
{
    public class CreateReport : ICreateReport
    {
        private readonly IGetOrderList _getOrder;
        public CreateReport(IGetOrderList getOrder)
        {
            _getOrder = getOrder;
        }

        public List<ReportModel> Execute(DateTime from, DateTime to)
        {
            Task<List<OrderModel>> a = _


            List<ReportModel> orders = _getOrder.Execute(from, to);
            return orders;
        }
    }
}
