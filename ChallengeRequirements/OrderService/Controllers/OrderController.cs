
using Microsoft.AspNetCore.Mvc;
using OrderService.Application.Common;
using OrderService.Application.Queries;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController: ControllerBase
    {
        public readonly IAddOrderQuery _queryNewOrder;
        public readonly IGetOrderListQuery _queryGetOrder;
        public OrderController(IAddOrderQuery queryNewOrder, IGetOrderListQuery queryGetOrder)
        {
            _queryNewOrder = queryNewOrder;
            _queryGetOrder = queryGetOrder;
        }

        [HttpGet]
        public List<OrderModel> Get()
        {
            return _queryGetOrder.Execute();
        }

        [HttpPost]
        public void AddOrder(OrderModel orderModel)
        {
            _queryNewOrder.New(orderModel);
        }
    }
}
