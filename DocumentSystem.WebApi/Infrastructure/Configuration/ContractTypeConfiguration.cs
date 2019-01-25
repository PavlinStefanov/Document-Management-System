using DocumentSystem.WebApi.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentSystem.WebApi.Infrastructure.Configuration
{
    public class ContractTypeConfiguration : IEntityTypeConfiguration<ContractType>
    {
        public void Configure(EntityTypeBuilder<ContractType> builder)
        {
            builder.ToTable("ContractType");
            builder.HasKey(x => x.TypeId).ForSqlServerIsClustered(true);
            builder.Property(x => x.TypeName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
        }
    }
}
