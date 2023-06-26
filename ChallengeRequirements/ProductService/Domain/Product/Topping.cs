using ProductService.Domain.Common;

namespace ProductService.Domain.Product
{
    public class Topping : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }        
    }
}
