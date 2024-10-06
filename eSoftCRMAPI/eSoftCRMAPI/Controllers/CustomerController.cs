using ES.CRM.Application.Services.Customer;
using ES.CRM.Domain.Models.InputModels;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace eSoftCRMAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerService _customerService;
        private readonly IValidator<CustomerRegisterRequest> _validator;

        public CustomerController(ILogger<CustomerController> logger, ICustomerService customerService, IValidator<CustomerRegisterRequest> validator = null)
        {
            _logger = logger;
            _customerService = customerService;
            _validator = validator;
        }

        [HttpPost("{customerId}/convert")]
        public async Task<IActionResult> ConvertLeadToCustomer(int customerId)
        {
            var customer = await _customerService.ConvertLeadToCustomer(customerId);
            return customer != null ? Ok(customer) : NotFound();
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterCustomer([FromBody] CustomerRegisterRequest request)
        {
            var validationResult = await _validator.ValidateAsync(request);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var result = await _customerService.RegisterCustomerAsync(request);
            return Ok(result);
        }
    }
}