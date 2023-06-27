using OrderService.Domain.Order;

namespace OrderService.Database
{
    public class MockOrderDB : IOrderDB
    {        
        public static List<Order> Orders { get; set; }//It can be upgraded by OrderMaster and OrderDetail here
        public MockOrderDB()
        {
            if (Orders == null)
            {
                Orders = new List<Order>();

                //Mock data 
                Orders.Add(new Order
                {
                    Id = 1,
                    StoreId = 1,
                    Flavour = "Milk Tea",
                    Ice = "Full",
                    Topping = "Cream Top",
                    OrderPrice = 32,
                    OrderDate = DateTime.Now.AddDays(-1),
                });
                Orders.Add(new Order
                {
                    Id = 1,
                    StoreId = 1,
                    Flavour = "Milk",
                    Ice = "Full",
                    Topping = "Cream Top",
                    OrderPrice = 22,
                    OrderDate = DateTime.Now.AddDays(-1),
                });
                Orders.Add(new Order
                {
                    Id = 2,
                    StoreId = 1,
                    Flavour = "Milk",
                    Ice = "Full",
                    Topping = "Oreo",
                    OrderPrice = 22,
                    OrderDate = DateTime.Now.AddDays(-2),
                });
                Orders.Add(new Order
                {
                    Id = 3,
                    StoreId = 2,
                    Flavour = "Lychee",
                    Ice = "Half",
                    Topping = "Tapioca Pearls",
                    OrderPrice = 45,
                    OrderDate = DateTime.Now.AddDays(-1),
                });
                Orders.Add(new Order
                {
                    Id = 4,
                    StoreId = 2,
                    Flavour = "Lychee",
                    Ice = "None",
                    Topping = "Tapioca Pearls",
                    OrderPrice = 45,
                    OrderDate = DateTime.Now.AddDays(-3),
                });
                Orders.Add(new Order
                {
                    Id = 5,
                    StoreId = 3,
                    Flavour = "Brown Sugar",
                    Ice = "Full",
                    Topping = "Tapioca Pearls",
                    OrderPrice = 85,
                    OrderDate = DateTime.Now,
                });
            }
        }
        
    }
}