using ES.CRM.Domain.Models.InputModels;
using ES.CRM.Domain.Models.ResultModels;

namespace ES.CRM.Application.Services.PriceAgreement
{
    public class PriceAgreementService : IPriceAgreementService
    {
        Task<CreatePriceAgreementResponse> IPriceAgreementService.CreatePriceAgreement(CreatePriceAgreementRequest createPriceAgreementRequest)
        {
            throw new NotImplementedException();
        }
    }
}
