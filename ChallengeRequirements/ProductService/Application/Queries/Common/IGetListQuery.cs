using ProductService.Application.Common;

namespace ProductService.Application.Queries.Common
{
    public interface IGetListQuery<T>
    {
        List<T> Execute();
    }
}
