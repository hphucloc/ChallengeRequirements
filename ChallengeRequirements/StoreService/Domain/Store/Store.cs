using StoreService.Domain.Common;

namespace StoreService.Domain.Store
{
    public class Store: IEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }
    }
}
