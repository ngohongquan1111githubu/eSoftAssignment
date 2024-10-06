namespace ES.CRM.Domain.Models.InternalModels.Input
{
    public class InternalCustomerRegisterRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsLead { get; set; }
    }
}
