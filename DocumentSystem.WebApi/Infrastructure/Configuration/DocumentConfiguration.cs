using DocumentSystem.WebApi.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentSystem.WebApi.Infrastructure.Configuration
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Documents");
            builder.HasKey(x => x.DocumentId).ForSqlServerIsClustered(true);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Size).IsRequired();
            builder.Property(x => x.Md5HashCode).HasMaxLength(40).IsRequired();
            builder.Property(x => x.IsCompleted).HasDefaultValue(false).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.HasOne(x => x.Contract).WithMany(x => x.Documents)
                .HasForeignKey(x => x.ContractId);
        }
    }
}
