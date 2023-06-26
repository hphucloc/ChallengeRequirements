using ProductService.Application.Queries.GetStoreList;
using Microsoft.AspNetCore.Mvc;
using ProductService.Application.Common;
using ProductService.Domain.Product;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToppingController : ControllerBase
    {
        public readonly IGetToppingListQuery _query;
        public ToppingController(IGetToppingListQuery query)
        {
            _query= query;
        }

        [HttpGet]
        public List<ToppingModel> Get()
        {
            return _query.Execute();
        }
    }
}
