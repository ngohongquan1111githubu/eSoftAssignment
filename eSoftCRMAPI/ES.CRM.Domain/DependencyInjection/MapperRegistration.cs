using ES.CRM.Domain.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace ES.CRM.Domain.DependencyInjection
{
    public static class MapperRegistration
    {
        public static IServiceCollection RegisterMappers(this IServiceCollection services)
        {
            services.AddTransient<CustomerRegisterMapper>();
            return services;
        }
    }
}
