using OrderService.Domain.Order;

namespace OrderService.Database
{
    public class MockOrderDB : IOrderDB
    {
        public static List<Order> Orders { get; set; }
        public MockOrderDB()
        {
            if (Orders == null)
                Orders = new List<Order>();
        }
        
    }
}