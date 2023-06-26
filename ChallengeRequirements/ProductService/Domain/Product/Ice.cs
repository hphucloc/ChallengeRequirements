using ProductService.Domain.Common;

namespace ProductService.Domain.Product
{
    public class Ice:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
