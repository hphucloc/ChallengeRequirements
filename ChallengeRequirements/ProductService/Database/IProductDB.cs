using ProductService.Domain.Product;

namespace ProductService.Database
{
    public interface IProductDB
    {
        List<Flavour> flavours { get; }
        List<Ice> ice { get; }
        List<Topping> toppings { get; }
    }
}
