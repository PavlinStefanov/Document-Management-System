using Microsoft.EntityFrameworkCore;

namespace DocumentSystem.WebApi.Infrastructure.Context
{
    public interface IDocumentDbContextFactory<out TContext> where TContext : IDocumentDbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        TContext Create(DbContextOptions options);
    }
}
