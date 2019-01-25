using Microsoft.EntityFrameworkCore;

namespace DocumentSystem.WebApi.Infrastructure.Context
{
    public class DocumentDbContextFactory : IDocumentDbContextFactory<IDocumentDbContext>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public IDocumentDbContext Create(DbContextOptions options)
        {
            //return new DocumentDbContext();
            return new DocumentDbContext(options);
        }
    }
}
