using ProductService.Application.Common;
using ProductService.Repository;

namespace ProductService.Application.Queries.GetStoreList
{
    public class GetIceListQuery : IGetIceListQuery
    {
        private readonly IIceRepository _repo;
        public GetIceListQuery(IIceRepository repo)
        {
            _repo = repo;
        }

        public List<IceModel> Execute()
        {
            var ice = _repo.GetAll()
                .Select(x => new IceModel()
                {
                    Id = x.Id,
                    Name = x.Name,                   
                });

            return ice.ToList();
        }
    }
}
