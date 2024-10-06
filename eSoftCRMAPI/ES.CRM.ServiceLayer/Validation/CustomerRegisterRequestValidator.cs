using ES.CRM.Domain.Models.InputModels;
using FluentValidation;

namespace ES.CRM.Application.Validation
{
    public class CustomerRegisterRequestValidator : AbstractValidator<CustomerRegisterRequest>
    {
        public CustomerRegisterRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name cannot be longer than 100 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .Matches(@"^\d{10,15}$").WithMessage("Phone number must be between 10 and 15 digits.");
        }
    }
}
