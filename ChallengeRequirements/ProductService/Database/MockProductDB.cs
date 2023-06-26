using ProductService.Domain.Product;

namespace ProductService.Database
{
    public class MockProductDB : IProductDB
    {
        public List<Flavour> flavours => new List<Flavour>
        { 
            new Flavour {Id = 1, Name = "Milk Tea"},
            new Flavour {Id = 2, Name = "Premium Milk Tea"},
            new Flavour {Id = 3, Name = "Lychee"},
            new Flavour {Id = 4, Name = "Brown Sugar"},
        };

        public List<Ice> ice => new List<Ice>
        {
            new Ice {Id = 1, Name="Full"},
            new Ice {Id = 2, Name="Half"},
            new Ice {Id = 3, Name="None"},
        };

        public List<Topping> toppings => new List<Topping>
        {
            new Topping{Id = 1, Name="Tapioca Pearls"},
            new Topping{Id = 2, Name="Jelly"},
            new Topping{Id = 3, Name="Cream Top"},
            new Topping{Id = 4, Name="Oreo"},
        };
       
    }
}