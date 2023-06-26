using ProductService.Application.Common;
using ProductService.Repository;

namespace ProductService.Application.Queries.GetStoreList
{
    public class GetFlavourListQuery : IGetFlavourListQuery
    {
        private readonly IFlavourRepository _repo;
        public GetFlavourListQuery(IFlavourRepository repo)
        {
            _repo = repo;
        }

        public List<FlavourModel> Execute()
        {
            var flavours = _repo.GetAll()
                .Select(x => new FlavourModel()
                {
                    Id = x.Id,
                    Name = x.Name,                   
                });

            return flavours.ToList();
        }
    }
}
