

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
            
            //Design pattern can be appply here
            if(orderModel.Flavour== "Brown Sugar" && 
                orderModel.Ice!="Full" && 
                orderModel.Topping != "Tapioca Pearls")
            {
                throw new Exception("`Brown Sugar` which must always have" +
                    " `Full` `Ice` and `Tapioca Pearls` topping, nothing else");
            }

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
