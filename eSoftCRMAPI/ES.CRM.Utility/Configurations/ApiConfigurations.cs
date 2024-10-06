using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.CRM.Utility.Configurations
{
    public class ApiConfigurations
    {
        private readonly IConfiguration _configuration;

        public ApiConfigurations(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public  string CustomerApiBaseUrl() { 
            return _configuration.GetVa
        }
    }


"ApiSettings": {
    "Customer": {
        "BaseUrl": "https://www.ef-pim.com",//fake url
      "ProductUri": "/create"
    }
}
