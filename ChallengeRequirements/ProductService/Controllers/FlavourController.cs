using ProductService.Application.Queries.GetStoreList;
using Microsoft.AspNetCore.Mvc;
using ProductService.Application.Common;
using ProductService.Domain.Product;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlavourController: ControllerBase
    {
        public readonly IGetFlavourListQuery _query;
        public FlavourController(IGetFlavourListQuery query)
        {
            _query= query;
        }

        [HttpGet]
        public List<FlavourModel> Get()
        {
            return _query.Execute();
        }
    }
}
