namespace ES.CRM.Domain.Models.InputModels
{
    public class CustomerRegisterRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsLead { get; set; }
    }
}
