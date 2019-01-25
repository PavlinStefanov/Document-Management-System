using DocumentSystem.WebApi.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentSystem.WebApi.Infrastructure.Configuration
{
    public class DocumentChunkConfiguration : IEntityTypeConfiguration<DocumentChunk>
    {
        public void Configure(EntityTypeBuilder<DocumentChunk> builder)
        {
            builder.ToTable("DocumentsChunks");
            builder.HasKey(x => x.ChunkId).ForSqlServerIsClustered(true); 
            builder.Property(x => x.ChunkSize).IsRequired();
            builder.Property(x => x.Md5HashCode).HasMaxLength(40).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.HasOne(x => x.Document).WithMany(x => x.DocumentChunks)
                .HasForeignKey(x => x.DocumentId);
        }
    }
}
