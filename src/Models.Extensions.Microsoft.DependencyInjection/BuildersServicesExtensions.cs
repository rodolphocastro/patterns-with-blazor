using System;

using Models.Builders;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BuildersServicesExtensions
    {
        public static IServiceCollection AddModelsBuilders(this IServiceCollection services)
        {
            if (services is null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddTransient<FluentPersonBuilder>();
            services.AddTransient<FunctionalPersonBuilder>();
            services.AddTransient<InheritablePersonBuilder>();
            services.AddTransient<FluentAddressBuilder>();
            services.AddTransient<FunctionalAddressBuilder>();
            services.AddTransient<FacetedPersonBuilder>();

            return services;
        }
    }
}
