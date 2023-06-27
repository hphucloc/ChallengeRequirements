namespace ReportService.Infrastructure.GetList
{
    public class GetOrderList : IGetOrderList
    {      
        public GetOrderList()
        {          
        }

        private const string baseuri = "http://orderservice:80/"; //can be store in config
        public async Task<List<OrderModel>> Execute(DateTime from, DateTime to)
        {
            using (var client = new HttpClient())
            {
                var swaggerClient = new swaggerClient(baseuri, client);
                var orders = await swaggerClient.OrderAllAsync().ConfigureAwait(false);
                return orders.Where(x => x.OrderDate >= from && x.OrderDate <= to).ToList();
            }           
        }
    }
}
