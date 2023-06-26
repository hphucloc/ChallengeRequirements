using OrderService.Domain.Order;

namespace OrderService.Database
{
    public interface IOrderDB
    {
        static List<Order> Orders { get; set; }
    }
}
