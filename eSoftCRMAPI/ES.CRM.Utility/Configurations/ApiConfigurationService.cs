
using Microsoft.Extensions.Options;

namespace ES.CRM.Utility.Configurations
{

    public class ApiConfigurationService
    {
        private readonly ApiSettings _apiSettings;

        public ApiConfigurationService(IOptions<ApiSettings> apiSettings)
        {
            _apiSettings = apiSettings.Value;
        }

        public string GetCustomerBaseUrl()
        {
            return _apiSettings.Customer.BaseUrl;
        }

        public string GetCustomerProductUri()
        {
            return _apiSettings.Customer.ProductUri;
        }

        public string GetCustomerProductEndpoint()
        {
            return $"{_apiSettings.Customer.BaseUrl}{_apiSettings.Customer.ProductUri}";
        }
    }

}
