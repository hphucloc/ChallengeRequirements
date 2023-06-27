
using ReportService.Infrastructure.Common;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ReportService.Infrastructure.GetList
{
    public class GetOrderList : IGetOrderList
    {      
        public GetOrderList()
        {          
        }

        private const string uri = "https://localhost:44385/"; //can be store in config
        public async Task<List<OrderModel>> Execute(DateTime from, DateTime to)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await client.GetAsync("api/Order/");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    List<OrderModel> res  = JsonSerializer.Deserialize<List<OrderModel>>(result);

                    return res;
                }
                else
                {
                    throw new Exception("Error in call OrderAPI");
                }
            }
           
        }
    }
}
