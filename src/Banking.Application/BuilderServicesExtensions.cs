using Microsoft.Extensions.DependencyInjection;

namespace Banking.Application
{
    public static class BuilderServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(
                config => config.RegisterServicesFromAssembly(
                    typeof(BuilderServicesExtensions).Assembly));

            return services;
        }
    }
}
