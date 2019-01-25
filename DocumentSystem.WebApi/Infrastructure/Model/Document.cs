using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentSystem.WebApi.Infrastructure.Model
{
    public class Document
    {
        public Document()
        {
            DocumentChunks = new HashSet<DocumentChunk>();
        }

        public int DocumentId { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Md5HashCode { get; set; }
        public bool IsCompleted { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public int ContractId { get; set; }
        public Contract Contract { get; set; }
        public virtual ICollection<DocumentChunk> DocumentChunks { get; set; }
    }
}
