using StoreService.Application.Queries.GetStoreList;
using Microsoft.AspNetCore.Mvc;
using StoreService.Application.Common;

namespace StoreService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController: ControllerBase
    {
        public readonly IGetStoresListQuery _query;
        public StoreController(IGetStoresListQuery query)
        {
            _query= query;
        }

        [HttpGet]
        public List<StoreModel> Get()
        {
            return _query.Execute();
        }
    }
}
