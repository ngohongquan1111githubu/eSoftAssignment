using ES.CRM.Application.Services.PriceAgreement;
using ES.CRM.Domain.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace eSoftCRMAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PriceAgreementController : ControllerBase
    {
        private readonly ILogger<PriceAgreementController> _logger;
        private readonly IPriceAgreementService _priceAgreementService;

        public PriceAgreementController(ILogger<PriceAgreementController> logger, IPriceAgreementService priceAgreementService)
        {
            _logger = logger;
            _priceAgreementService = priceAgreementService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePriceAgreement([FromBody] CreatePriceAgreementRequest createPriceAgreementRequest)
        {
            var agreement = await _priceAgreementService.CreatePriceAgreement(createPriceAgreementRequest);
            return Ok(agreement);
        }
    }
}