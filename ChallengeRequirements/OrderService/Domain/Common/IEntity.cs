namespace OrderService.Domain.Common
{
    public interface IEntity
    {
        int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public double OrderPrice { get; set; }
    }
}
