using DocumentSystem.WebApi.Infrastructure.Context;
using DocumentSystem.WebApi.Resources;
using DocumentSystem.WebApi.Resources.Uploading;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentSystem.WebApi.Services.Uploading.Contracts
{
    public class ContractUploadCommandService
    {
        private readonly IDocumentDbContextFactory<IDocumentDbContext> _dbContextFactory;
        private readonly DbContextOptions _options;

        public ContractUploadCommandService(IDocumentDbContextFactory<IDocumentDbContext> dbContextFactory, DbContextOptions options)
        {
            _dbContextFactory = dbContextFactory;
            _options = options;
        }

        /// <summary>
        /// method that allow as to create new contract
        /// </summary>
        /// <param name="contract"></param>
        public void CreateContract(ContractUploadRequest contract)
        {
            try
            {
                using (var context = _dbContextFactory.Create(_options))
                {
                    context.Contracts.Add(contract.ToEntity());
                    context.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Unable to create new contract for '{contract.Name}'.", ex);
            }
        }
    }
}
