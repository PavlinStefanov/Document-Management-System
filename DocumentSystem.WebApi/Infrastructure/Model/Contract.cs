using System;
using System.Collections.Generic;

namespace DocumentSystem.WebApi.Infrastructure.Model
{
    public class Contract
    {
        public Contract()
        {
            Documents = new HashSet<Document>();
        }
        public int ContractId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset LastUpdate { get; set; }
        public int ContractTypeId { get; set; }
        public ContractType ContractType { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}
