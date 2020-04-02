using System;

using Models.Factories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class FactoriesServicesExtensions
    {
        public static IServiceCollection AddModelsFactories(this IServiceCollection services)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            _ = services.AddSingleton<VehicleFactory>();
            return services;
        }
    }
}
