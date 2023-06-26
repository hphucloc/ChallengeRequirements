using ProductService.Application.Queries.GetStoreList;
using Microsoft.AspNetCore.Mvc;
using ProductService.Application.Common;
using ProductService.Domain.Product;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IceController: ControllerBase
    {
        public readonly IGetIceListQuery _query;
        public IceController(IGetIceListQuery query)
        {
            _query= query;
        }

        [HttpGet]
        public List<IceModel> Get()
        {
            return _query.Execute();
        }
    }
}
