using ES.CRM.Domain.Models.InputModels;
using ES.CRM.Domain.Models.ResultModels;

namespace ES.CRM.Application.Services.Customer
{
    public interface ICustomerService
    {
        Task<CustomerRegisterResponse> RegisterCustomerAsync(CustomerRegisterRequest request);

        Task<ConvertLeadToCustomerResponse> ConvertLeadToCustomer(int customerId);
    }
}
