namespace ES.CRM.Domain.Models.InternalModels.Output
{
    public class InternalCustomerResponse
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public bool IsLead { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
