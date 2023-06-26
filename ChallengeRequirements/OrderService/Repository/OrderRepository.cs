using OrderService.Database;
using OrderService.Domain.Order;
using OrderService.Repository;

namespace OrderService.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IOrderDB _db;
        public OrderRepository(IOrderDB db)
        {
            _db = db;
        }
        public void Add(Order entity)
        {
            MockOrderDB.Orders.Add(entity);
        }

        public Order? Get(int id)
        {
            if (MockOrderDB.Orders != null)
                return MockOrderDB.Orders.FirstOrDefault(x => x.Id == id);

            return null;
        }

        public IQueryable<Order> GetAll()
        {
            return MockOrderDB.Orders.AsQueryable();
        }     
    }
}
