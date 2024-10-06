using ES.CRM.Domain.Models.InputModels;
using ES.CRM.Domain.Models.ResultModels;

namespace ES.CRM.Application.Services.PriceAgreement
{
    public interface IPriceAgreementService
    {
       Task<CreatePriceAgreementResponse> CreatePriceAgreement(CreatePriceAgreementRequest createPriceAgreementRequest);
    }
}
