using Microsoft.EntityFrameworkCore;
using StoreService.Domain.Store;

namespace StoreService.Database
{
    public class MockStoreDB : IStoreDB
    {
        List<Store> IStoreDB.Stores => new List<Store>()
        {
            new Store { Id = 1, Name = "Store1", Address = "86 Sale Street, Spring Hill, New South Wales" },
            new Store { Id = 2, Name = "Store2", Address = "99 Bayview Close, Marlborough, Queensland " },
            new Store { Id = 3, Name = "Store3", Address = "56 Devon Street, Torrensville Plaza, South Australia" }
        };     
    }
}