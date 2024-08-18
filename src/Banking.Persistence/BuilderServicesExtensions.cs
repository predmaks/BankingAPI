using Microsoft.Extensions.DependencyInjection;
using Banking.Persistence.Interfaces;

namespace Banking.Persistence
{
    public static class BuilderServicesExtensions
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IDatabaseService, FakeDatabase>();

            return services;
        }
    }
}
