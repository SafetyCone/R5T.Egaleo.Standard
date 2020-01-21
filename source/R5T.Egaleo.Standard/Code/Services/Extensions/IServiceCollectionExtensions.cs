using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Egaleo.Default;


namespace R5T.Egaleo.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddOrganizationDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<IOrganizationDirectoryNameConvention, OrganizationDirectoryNameConvention>();

            return services;
        }
    }
}
