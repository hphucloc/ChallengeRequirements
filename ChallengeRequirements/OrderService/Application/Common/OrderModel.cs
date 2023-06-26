namespace OrderService.Application.Common
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int StoreId { get; set; }      
        public string Flavour { get; set; }
        public string Topping { get; set; }
        public string Ice { get; set; }
        public double OrderPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
