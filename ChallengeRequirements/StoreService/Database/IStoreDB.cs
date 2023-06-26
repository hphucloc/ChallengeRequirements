using Microsoft.EntityFrameworkCore;
using StoreService.Domain.Store;

namespace StoreService.Database
{
    public interface IStoreDB
    {
        List<Store> Stores { get; }
    }
}
