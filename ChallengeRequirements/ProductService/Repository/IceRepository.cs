using ProductService.Database;
using ProductService.Domain.Product;

namespace ProductService.Repository
{
    public class IceRepository : IIceRepository
    {
        private readonly IProductDB _db;
        public IceRepository(IProductDB db)
        {
            _db = db;
        }

        public void Add(Ice entity)
        {
            _db.ice.Add(entity);
        }

        public Ice? Get(int id)
        {
            if (_db.ice != null)
                return _db.ice.FirstOrDefault(x => x.Id == id);

            return null;
        }

        public IQueryable<Ice> GetAll()
        {
            return _db.ice.AsQueryable();
        }

        public void Remove(Ice entity)
        {
            _db.ice.Remove(entity);
        }
    }
}
