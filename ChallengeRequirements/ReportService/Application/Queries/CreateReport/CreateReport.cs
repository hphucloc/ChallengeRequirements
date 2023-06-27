

namespace ReportService.Application.Queries
{
    public class CreateReport : ICreateReport
    {
        private readonly IStoreRepository _repo;
        public CreateReport(IStoreRepository repo)
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
