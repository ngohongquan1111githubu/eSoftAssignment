namespace ES.CRM.Domain.Models.InputModels
{
    public class CustomerRegisterResponse
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public bool IsLead { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
