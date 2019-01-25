using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentSystem.WebApi.Infrastructure.Model
{
    public class DocumentChunk
    {
        public int ChunkId { get; set; }
        public int ChunkSize { get; set; }
        public byte[] Chunk { get; set; }
        public string Md5HashCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
    }
}
