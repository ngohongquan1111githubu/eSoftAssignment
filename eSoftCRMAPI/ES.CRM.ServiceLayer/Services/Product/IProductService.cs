using ES.CRM.Domain.Models.ResultModels;

namespace ES.CRM.Application.Services.Product
{
    public interface IProductService
    {
        Task<GetProductsResponse> GetProducts(string keyword, int? page = 1, int? pageSize = 10);
    }
}
