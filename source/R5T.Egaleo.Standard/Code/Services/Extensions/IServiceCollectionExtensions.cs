using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Egaleo.Default;


namespace R5T.Egaleo.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IOrganizationDirectoryNameConvention"/> service.
        /// </summary>
        public static IServiceCollection AddOrganizationDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddDefaultOrganizationDirectoryNameConvention();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IOrganizationDirectoryNameConvention"/> service.
        /// </summary>
        public static ServiceAction<IOrganizationDirectoryNameConvention> AddOrganizationDirectoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOrganizationDirectoryNameConvention>(() => services.AddOrganizationDirectoryNameConvention());
            return serviceAction;
        }
    }
}
