using ProductService.Domain.Product;

namespace ProductService.Application.Common
{
    public class ProductModel
    {
        public  Flavour Flavour { get; set; }

        public Ice Ice { get; set; }

        public Topping Topping { get; set; }
    }
}
