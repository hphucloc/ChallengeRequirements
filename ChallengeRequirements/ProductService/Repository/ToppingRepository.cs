using ProductService.Database;
using ProductService.Domain.Product;

namespace ProductService.Repository
{
    public class ToppingRepository : IToppingRepository
    {
        private readonly IProductDB _db;
        public ToppingRepository(IProductDB db)
        {
            _db = db;
        }

        public void Add(Topping entity)
        {
            _db.toppings.Add(entity);
        }

        public Topping? Get(int id)
        {
            if (_db.toppings != null)
                return _db.toppings.FirstOrDefault(x => x.Id == id);

            return null;
        }

        public IQueryable<Topping> GetAll()
        {
            return _db.toppings.AsQueryable();
        }

        public void Remove(Topping entity)
        {
            _db.toppings.Remove(entity);
        }
    }
}
