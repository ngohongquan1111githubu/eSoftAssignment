using ES.CRM.Domain.Models.InputModels;
using ES.CRM.Domain.Models.InternalModels.Input;
using ES.CRM.Domain.Models.InternalModels.Output;

namespace ES.CRM.Domain.Mappers
{
    public class CustomerRegisterMapper
    {
        public InternalCustomerRegisterRequest ToInternalRequest(CustomerRegisterRequest request)
        {
            InternalCustomerRegisterRequest result = new InternalCustomerRegisterRequest();
            /// Do the mapper
            return result;
        }

        public CustomerRegisterResponse ToExternalResponse(InternalCustomerResponse response)
        {
            CustomerRegisterResponse result = new CustomerRegisterResponse();
            /// Do the mapper
            return result;
        }
    }
}
