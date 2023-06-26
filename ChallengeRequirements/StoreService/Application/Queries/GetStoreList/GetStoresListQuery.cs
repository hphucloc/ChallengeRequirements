using StoreService.Application.Common;
using StoreService.Repository;

namespace StoreService.Application.Queries.GetStoreList
{
    public class GetStoresListQuery : IGetStoresListQuery
    {
        private readonly IStoreRepository _repo;
        public GetStoresListQuery(IStoreRepository repo)
        {
            _repo = repo;
        }

        public List<StoreModel> Execute()
        {
            var stores = _repo.GetAll()
                .Select(x => new StoreModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address
                });

            return stores.ToList();
        }
    }
}
