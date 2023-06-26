using StoreService.Application.Common;

namespace StoreService.Application.Queries.GetStoreList
{
    public interface IGetStoresListQuery
    {
        List<StoreModel> Execute();
    }
}
