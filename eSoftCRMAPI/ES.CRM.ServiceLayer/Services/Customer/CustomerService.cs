using ES.CRM.Domain.Mappers;
using ES.CRM.Domain.Models.InputModels;
using ES.CRM.Domain.Models.InternalModels.Output;
using ES.CRM.Domain.Models.ResultModels;
using System.Net.Http.Json;

namespace ES.CRM.Application.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly CustomerRegisterMapper _mapper;

        public CustomerService(CustomerRegisterMapper mapper, IHttpClientFactory httpClientFactory)
        {
            _mapper = mapper;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<CustomerRegisterResponse> RegisterCustomerAsync(CustomerRegisterRequest request)
        {
            var customerInternalInput = _mapper.ToInternalRequest(request);

            var httpClient = _httpClientFactory.CreateClient();

            var response = await httpClient.PostAsJsonAsync("https://internal.api/customer/register", customerInternalInput);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<InternalCustomerResponse>();
                return _mapper.ToExternalResponse(result);
            }

            throw new HttpRequestException("Failed to register the customer.");
        }

        Task<ConvertLeadToCustomerResponse> ICustomerService.ConvertLeadToCustomer(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
