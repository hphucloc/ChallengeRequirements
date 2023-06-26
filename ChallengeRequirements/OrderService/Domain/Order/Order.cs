using OrderService.Domain.Common;

namespace OrderService.Domain.Order
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Flavour { get; set; }
        public string Topping { get; set; }
        public string Ice { get; set; }
        public double OrderPrice { get; set; }
    }
}
