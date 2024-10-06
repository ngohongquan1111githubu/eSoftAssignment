using ES.CRM.Application.Services.Customer;
using ES.CRM.Application.Services.PriceAgreement;
using ES.CRM.Application.Services.Product;
using ES.CRM.Application.Validation;
using ES.CRM.Domain.Models.InputModels;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace ES.CRM.Application.DependencyInjection
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            return services.RegisterValidators()
                           .RegisterServices();
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IPriceAgreementService, PriceAgreementService>();
            services.AddScoped<IProductService, ProductService>();
            return services;
        }

        public static IServiceCollection RegisterValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CustomerRegisterRequest>, CustomerRegisterRequestValidator>();
            return services;
        }
    }
}
