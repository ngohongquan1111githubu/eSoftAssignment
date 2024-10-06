using ES.CRM.Application.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace eSoftCRMAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProducts([FromQuery] string keyword = null, [FromQuery] int? page = 1, [FromQuery] int? pageSize = 10)
        {
            var products = await _productService.GetProducts(keyword, page, pageSize);
            return Ok(products);
        }
    }
}