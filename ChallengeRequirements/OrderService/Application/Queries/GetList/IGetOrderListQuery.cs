using OrderService.Application.Common;

namespace OrderService.Application.Queries
{
    public interface IGetOrderListQuery
    {
        List<OrderModel> Execute();
    }
}
