using OrderService.Application.Common;

namespace OrderService.Application.Queries
{
    public interface IAddOrderQuery
    {
        void New(OrderModel orderModel);
    }
}
