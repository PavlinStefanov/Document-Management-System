using System;
using Microsoft.EntityFrameworkCore;
using DocumentSystem.WebApi.Infrastructure.Model;

namespace DocumentSystem.WebApi.Infrastructure.Context
{
    public interface IDocumentDbContext : IDisposable
    {
        #region
        DbSet<Contract> Contracts { get; set; }
        DbSet<ContractType> ContractTypes { get; set; }
        DbSet<Document> Documents { get; set; }
        DbSet<DocumentChunk> DocumentChunks { get; set; }
        #endregion

        /// <summary>
        /// save changes method abstraction
        /// </summary>
        void Commit();
    }
}
