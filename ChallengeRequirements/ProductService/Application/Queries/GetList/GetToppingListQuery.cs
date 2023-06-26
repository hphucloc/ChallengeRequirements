using ProductService.Application.Common;
using ProductService.Repository;

namespace ProductService.Application.Queries.GetStoreList
{
    public class GetToppingListQuery : IGetToppingListQuery
    {
        private readonly IToppingRepository _repo;
        public GetToppingListQuery(IToppingRepository repo)
        {
            _repo = repo;
        }

        public List<ToppingModel> Execute()
        {
            var toppings = _repo.GetAll()
                .Select(x => new ToppingModel()
                {
                    Id = x.Id,
                    Name = x.Name,                   
                });

            return toppings.ToList();
        }
    }
}
