using StoreService.Database;
using StoreService.Domain.Store;

namespace StoreService.Repository
{
    public class StoreRepository : IStoreRepository
    {
        private readonly IStoreDB _db;
        public StoreRepository(IStoreDB db)
        {
            _db = db;
        }
        public void Add(Store entity)
        {
            _db.Stores.Add(entity);
        }

        public Store? Get(int id)
        {
            if (_db.Stores != null)
                return _db.Stores.FirstOrDefault(x => x.Id == id);

            return null;
        }

        public IQueryable<Store> GetAll()
        {
            return _db.Stores.AsQueryable();
        }

        public void Remove(Store entity)
        {
            _db.Stores.Remove(entity);
        }
    }
}
