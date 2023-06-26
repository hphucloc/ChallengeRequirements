using OrderService.Application.Common;
using OrderService.Repository;

namespace OrderService.Application.Queries
{
    public class GetOrderListQuery : IGetOrderListQuery
    {
        private readonly IOrderRepository _repo;
        public GetOrderListQuery(IOrderRepository repo)
        {
            _repo = repo;
        }

        public List<OrderModel> Execute()
        {
            var orders = _repo.GetAll()
                .Select(x => new OrderModel()
                {
                    Id = x.Id,
                    StoreId= x.StoreId,                   
                    Flavour = x.Flavour,
                    Ice = x.Ice,
                    Topping = x.Topping,
                    OrderPrice = x.OrderPrice,
                    OrderDate = x.OrderDate
                });

            return orders.ToList();
        }
    }
}
