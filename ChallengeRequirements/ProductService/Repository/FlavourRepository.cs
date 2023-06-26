using ProductService.Database;
using ProductService.Domain.Product;

namespace ProductService.Repository
{
    public class FlavourRepository : IFlavourRepository
    {
        private readonly IProductDB _db;
        public FlavourRepository(IProductDB db)
        {
            _db = db;
        }

        public void Add(Flavour entity)
        {
            _db.flavours.Add(entity);
        }

        public Flavour? Get(int id)
        {
            if (_db.flavours != null)
                return _db.flavours.FirstOrDefault(x => x.Id == id);

            return null;
        }

        public IQueryable<Flavour> GetAll()
        {
            return _db.flavours.AsQueryable();
        }

        public void Remove(Flavour entity)
        {
            _db.flavours.Remove(entity);
        }
    }
}
