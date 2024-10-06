namespace ES.CRM.Domain.Models.InputModels
{
    public class CreatePriceAgreementRequest
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public decimal AgreedPrice { get; set; }
    }
}
