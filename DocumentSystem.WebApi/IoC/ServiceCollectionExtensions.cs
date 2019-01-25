using DocumentSystem.WebApi.Infrastructure.Context;
using Microsoft.Extensions.DependencyInjection;

namespace DocumentSystem.WebApi.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services)
        {
            services.AddTransient<IDocumentDbContext, DocumentDbContext>();
            services.AddTransient<IDocumentDbContextFactory<IDocumentDbContext>, DocumentDbContextFactory>();
            return services;
        }
    }
}
