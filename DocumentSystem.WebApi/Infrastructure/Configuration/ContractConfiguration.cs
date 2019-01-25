using DocumentSystem.WebApi.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentSystem.WebApi.Infrastructure.Configuration
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("Contracts");
            builder.HasKey(x => x.ContractId).ForSqlServerIsClustered(true);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(300);
            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.LastUpdate).IsRequired();
            builder.HasOne(x => x.ContractType).WithMany(x => x.Contracts)
                .HasForeignKey(x => x.ContractTypeId);
        }
    }
}
