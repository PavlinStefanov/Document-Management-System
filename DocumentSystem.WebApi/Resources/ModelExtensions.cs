using DocumentSystem.WebApi.Infrastructure.Model;
using DocumentSystem.WebApi.Resources.Uploading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentSystem.WebApi.Resources
{
    public static class ModelExtensions
    {
        public static Contract ToEntity(this ContractUploadRequest contractRequest)
        {
            return new Contract
            {
                Name = contractRequest.Name
            };
        }
    }
}
