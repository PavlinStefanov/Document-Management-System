using System;
using Microsoft.EntityFrameworkCore;
using DocumentSystem.WebApi.Infrastructure.Model;
using DocumentSystem.WebApi.Infrastructure.Configuration;

namespace DocumentSystem.WebApi.Infrastructure.Context
{
    public class DocumentDbContext : DbContext, IDocumentDbContext
    {
        public DocumentDbContext() { }

        public DocumentDbContext(DbContextOptions options) : base(options)
        { }

        #region
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentChunk> DocumentChunks { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContractConfiguration());
            modelBuilder.ApplyConfiguration(new ContractTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentChunkConfiguration());
        }

        /// <summary>
        /// 
        /// </summary>
        public void Commit()
        {
            base.SaveChanges();
        }
    }
}
