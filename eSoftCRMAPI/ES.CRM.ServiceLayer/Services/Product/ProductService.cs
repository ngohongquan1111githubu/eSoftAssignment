using ES.CRM.Domain.Models.ResultModels;

namespace ES.CRM.Application.Services.Product
{
    internal class ProductService : IProductService
    {
        public Task<GetProductsResponse> GetProducts(string keyword, int? page = 1, int? pageSize = 10)
        {
            throw new NotImplementedException();
        }
    }
}
