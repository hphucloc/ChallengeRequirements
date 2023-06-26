

using OrderService.Application.Common;
using OrderService.Domain.Order;
using OrderService.Repository;

namespace OrderService.Application.Queries
{
    public class AddOrderQuery : IAddOrderQuery
    {
        private readonly IOrderRepository _repo;
        public AddOrderQuery(IOrderRepository repo)
        {
            _repo = repo;
        }

        public void New(OrderModel orderModel)
        {           
            _repo.Add(new Order()
            {
                Id = orderModel.Id,
                StoreId= orderModel.StoreId,
                OrderDate= DateTime.Now,
                Flavour= orderModel.Flavour,
                Ice= orderModel.Ice,
                Topping= orderModel.Topping,
                OrderPrice= orderModel.OrderPrice,
            });            
        }
    }
}
